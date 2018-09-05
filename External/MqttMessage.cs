namespace HackathonModule{
    public class MqttMessage{

        public string sensor {get;set;}
        public string payload {get;set;}

        public MqttMessageType MqttMessageType{
            get{
                switch(this.sensor){
                    case "temp": return MqttMessageType.Temperature;
                    case "hum": return MqttMessageType.Humidity;
                    case "peoplecount": return MqttMessageType.PeopleCount;
                    default: return MqttMessageType.Unknwon;
                }
            }
        }

        public double PayloadDoubleValue{
            get{
                double output = 0;
                if(double.TryParse(payload, out output)){
                    return output;
                }
                else{
                    return -1;
                }
            }
        }
    }
}