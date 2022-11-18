#define LIN_OUT 1  // use the log output function
#define FHT_N 64   // set to 64 point fht

#include <FHT.h>  // include the library

uint32_t loopTimer;

int16_t fifo[FHT_N];

uint8_t header[] = { 0xAC, 0xAB };

void setup() {
  Serial.begin(115200);  // use the serial port
}

void loop() {
  if (micros() - loopTimer > 10000) {
    loopTimer = micros();
    int16_t newData = analogRead(A0);
    rollFIFO(newData-512);
    for (int i = 0; i < FHT_N; i++) fht_input[i] = fifo[i];
    fht_window();   // window the data for better frequency response
    fht_reorder();  // reorder the data before doing the fht
    fht_run();      // process the data in the fht
    fht_mag_lin();  // take the output of the fht
    Serial.write(header, 2);
    Serial.write(newData);
    Serial.write(newData >> 8);
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