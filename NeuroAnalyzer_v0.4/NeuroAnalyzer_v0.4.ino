#define PULSE_D_LPF_K 0.995
#define MAX_P_INSTAB 0.5

#define LIN_OUT 1  // use the log output function
#define FHT_N 64   // set to 64 point fht

#include <FHT.h>  // include the library

float pIns;
uint8_t ppm;
uint32_t time, pulseTimer, pulsePeriod, p_pulsePeriod;
int32_t d_p;
bool pulseFlg;

int16_t fifo[FHT_N];

uint8_t header[] = { 0xAC, 0xAB };

void setup() {
  Serial.begin(115200);  // use the serial port
  pinMode(13, OUTPUT);
  pinMode(3, OUTPUT);
  pinMode(4, OUTPUT);
  digitalWrite(3, 1);
}

void loop() {
  if (micros() - time > 10000) {
    time = micros();
    int16_t newData = analogRead(A0);
    rollFIFO(newData - 512);
    for (int i = 0; i < FHT_N; i++) fht_input[i] = fifo[i];
    fht_window();   // window the data for better frequency response
    fht_reorder();  // reorder the data before doing the fht
    fht_run();      // process the data in the fht
    fht_mag_lin();  // take the output of the fht

    if (digitalRead(2) && !pulseFlg) {
      pulseFlg = true;
      pulsePeriod = millis() - pulseTimer;
      pulseTimer = millis();
      d_p = pulsePeriod - p_pulsePeriod;
      if (d_p < 0) d_p = -d_p;
      p_pulsePeriod = pulsePeriod;
    } else if (!digitalRead(2)) pulseFlg = false;

    pIns = (1 - PULSE_D_LPF_K) * (float(d_p) / pulsePeriod) + PULSE_D_LPF_K * pIns;

    if (pulsePeriod > 200) ppm = (60000.f / pulsePeriod);
    if (millis() - pulseTimer > 2000 || pIns > MAX_P_INSTAB) ppm = 0;

    Serial.write(header, 2);
    Serial.write(newData);
    Serial.write(newData >> 8);
    Serial.write(ppm);
    Serial.write(uint8_t(pIns*100));
    for (byte i = 0; i < FHT_N / 2; i++) {
      Serial.write(fht_lin_out[i]);
      Serial.write(fht_lin_out[i] >> 8);
    }
  }
}

void rollFIFO(uint16_t new_data) {
  for (int i = 0; i < FHT_N - 1; i++) fifo[i] = fifo[i + 1];
  fifo[FHT_N - 1] = new_data;
}