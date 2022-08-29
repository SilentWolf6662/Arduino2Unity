const int pin_button1 = 12; // yellow-left
const int pin_button2 = 8; // green-right
const int pin_button3 = 2;
const int pin_button4 = 4;

void setup() {
  Serial.begin(38400);

  pinMode(pin_button1, INPUT);
  pinMode(pin_button2, INPUT);
  pinMode(pin_button3, INPUT);
  pinMode(pin_button4, INPUT);

}

void loop() {
  if(digitalRead(pin_button1) == HIGH){
    Serial.println("1");
    Serial.write(1); // Unity will read this value 
    Serial.flush();
    delay(20); // This delay is important - 20 should be enough for a smooth transition. 
  }
  if(digitalRead(pin_button2) == HIGH){
    Serial.println("2");
    Serial.write(2); // Unity will read this value 
    Serial.flush();
    delay(20); // This delay is important - 20 should be enough for a smooth transition. 
  }
  if(digitalRead(pin_button3) == HIGH){
    Serial.println("3");
    Serial.write(3); // Unity will read this value 
    Serial.flush();
    delay(20); // This delay is important - 20 should be enough for a smooth transition. 
  }
  if(digitalRead(pin_button4) == HIGH){
    Serial.println("4");
    Serial.write(4); // Unity will read this value 
    Serial.flush();
    delay(20); // This delay is important - 20 should be enough for a smooth transition. 
  }
}
