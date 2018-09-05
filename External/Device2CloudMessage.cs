namespace AzureIoTEdgeModuleShared{
    using System;
    public class DeviceToCloudMessage{

        public DeviceToCloudMessage(){
            this.TimeStamp = DateTime.UtcNow.ToString("s");
        }
        
        public string DeviceId {get;set;}

        public string TimeStamp {get;set;}

        public string Sensor {get;set;}

        public double Value {get;set;}

        public int MessageLevel{get;set;}
    }
}