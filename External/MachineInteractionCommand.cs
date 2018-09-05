namespace AzureIoTEdgeFilterModule{
    using AzureIoTEdgeModuleShared;

    public class MachineInteractionCommand{
        public double Temperature { get; set; } 
        public double Humidity { get; set; } 

        public InteractionCommandLevel CommandLevel { get; set;}
    }    
}