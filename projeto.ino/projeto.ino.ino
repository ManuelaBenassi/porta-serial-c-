#define Led1 1
#define Led2 2
#define Led3 3
#define Led4 4
#define Led5 5
#define Led6 6 
#define Led7 7
#define Led8 8
int qtasVezes = 0;


void setup() {
 Serial.begin(9600);
 pinMode(Led1,OUTPUT);
 pinMode(Led2,OUTPUT);
 pinMode(Led3,OUTPUT);
 pinMode(Led4,OUTPUT);
 pinMode(Led5,OUTPUT);
 pinMode(Led6,OUTPUT);
 pinMode(Led7,OUTPUT);
 pinMode(Led8,OUTPUT);

}
void efeito1()
{
  while(qtasVezes < 3)
 {
  digitalWrite(Led1,HIGH);
  digitalWrite(Led2,HIGH);
  digitalWrite(Led3,HIGH);
  digitalWrite(Led4,HIGH);
  delay(500);
  digitalWrite(Led1,LOW);
  digitalWrite(Led2,LOW);
  digitalWrite(Led3,LOW);
  digitalWrite(Led4,LOW);
  delay(500);
  qtasVezes++;
}
Serial.write("0");
}

void efeito2()
{
  while(qtasVezes < 3)
 {
  digitalWrite(Led5,HIGH);
  digitalWrite(Led6,HIGH);
  digitalWrite(Led7,HIGH);
  digitalWrite(Led8,HIGH);
  delay(500);
  digitalWrite(Led5,LOW);
  digitalWrite(Led6,LOW);
  digitalWrite(Led7,LOW);
  digitalWrite(Led8,LOW);
  delay(500);
  qtasVezes++;
  
 }
  Serial.write("0");
}
void efeito3()
{

 digitalWrite(Led4,HIGH);
 digitalWrite(Led5,HIGH);
 delay(200);
 digitalWrite(Led3,HIGH);
 digitalWrite(Led6,HIGH);
 delay(200);
 digitalWrite(Led2,HIGH);
 digitalWrite(Led7,HIGH);
 delay(200);
 digitalWrite(Led1,HIGH);
 digitalWrite(Led8,HIGH);
 delay(200);
 digitalWrite(Led1,LOW);
 digitalWrite(Led3,LOW);
 digitalWrite(Led2,LOW);
 digitalWrite(Led4,LOW);
 digitalWrite(Led5,LOW);
 digitalWrite(Led7,LOW);
 digitalWrite(Led6,LOW);
 digitalWrite(Led8,LOW);
 Serial.write("0");


    
}
void efeito4(){
     digitalWrite(Led1,HIGH);
     digitalWrite(Led3,HIGH);
     delay(500);
     digitalWrite(Led1,LOW);
     digitalWrite(Led3,LOW);
     delay(500);
     digitalWrite(Led2,HIGH);
     digitalWrite(Led4,HIGH);
     delay(500);
     digitalWrite(Led2,LOW);
     digitalWrite(Led4,LOW);
     delay(500);
     digitalWrite(Led5,HIGH);
     digitalWrite(Led7,HIGH);
     delay(500);
     digitalWrite(Led5,LOW);
     digitalWrite(Led7,LOW);
     delay(500);
     digitalWrite(Led6,HIGH);
     digitalWrite(Led8,HIGH);
     delay(500);
     digitalWrite(Led6,LOW);
     digitalWrite(Led8,LOW);
     delay(500);
     Serial.write("0");
}
void efeito5(){
  digitalWrite(Led1,HIGH);
  digitalWrite(Led8,HIGH);
  delay(200);
  digitalWrite(Led2,HIGH);
  digitalWrite(Led7,HIGH);
  delay(200);
  digitalWrite(Led3,HIGH);
  digitalWrite(Led6,HIGH);
  delay(200);
  digitalWrite(Led4,HIGH);
  digitalWrite(Led5,HIGH);
  delay(200);
  digitalWrite(Led1,LOW);
  digitalWrite(Led3,LOW);
  digitalWrite(Led2,LOW);
  digitalWrite(Led4,LOW);
  digitalWrite(Led5,LOW);
  digitalWrite(Led7,LOW);
  digitalWrite(Led6,LOW);
  digitalWrite(Led8,LOW);
  Serial.write("0");
}

void loop() {
  if(Serial.available() > 0)
  {
char recieveVal;

recieveVal = Serial.read();
if(recieveVal == '1')
{
 efeito1();
}


if(recieveVal == '2')
{
  
 efeito2();
}
if(recieveVal == '3')
{
   efeito3();
}
if(recieveVal == '4')
{
 efeito4();
}
if(recieveVal == '5')
{
 efeito5();
}
qtasVezes = 0;
}
}


