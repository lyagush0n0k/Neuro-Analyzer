import processing.serial.*;

Serial port;

int spectrum[] = new int[32];
ArrayList<Integer> rawData = new ArrayList<>();
int rawDataLength = 64;

void setup() {
  size(640, 480);
  frameRate(180);
  background(255);
  for(int i = 0; i < rawDataLength; i++) rawData.add(0);

  port = new Serial(this, "COM4", 115200);
}

float alpha = 0, sum = 0;

void draw() {
  background(255);
  if (port.available() > 1) {
    while (port.read() != 0xAC);
    if (port.read() == 0xAB) {
      delay(10);
      int l = port.read();
      int h = port.read();
      rawData.add(((h << 8) | l) - 512);
      if(rawData.size() > rawDataLength) rawData.remove(0);
      for (int i = 0; i < 32; i++) {
        l = port.read();
        h = port.read();
        spectrum[i] = (h << 8) | l;
        spectrum[i] = spectrum[i];
      }
      port.clear();
    } else port.clear();
  }
  sum = 0;
   for(int i = 3; i < 7; i++) sum += spectrum[i];
   alpha = 0.03*sum + 0.97*alpha;
   
   fill(255, 0, 0);
   rect(60, 480-alpha*5, 80, alpha*5);

  for(int i = 0; i < rawDataLength-1; i++){
    stroke(0, 255, 0);
    line(i*640/rawDataLength, 240+rawData.get(i), (i+1)*640/rawDataLength, 240+rawData.get(i+1));
  }
  for (int i = 0; i < 32; i++) {
    noStroke();
    fill(0, 0, 255);
    rect(i*20, 480-spectrum[i], 20, spectrum[i]);
  }
}
