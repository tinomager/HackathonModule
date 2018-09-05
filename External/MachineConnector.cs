namespace AzureIoTEdgeFilterModule{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using AzureIoTEdgeModuleShared;

    public class MachineConnector{
        private string url;

        public MachineConnector(string url)
        {
            this.url = url;            
        }

        public bool InteractWithMachine(MachineInteractionCommand command){
            return this.SendRequest(new MachineCommand(){
                Type = "ShowStatus",
                Payload = JsonConvert.SerializeObject(command)
            }).Result;
        }

        public bool SendText(MachineSendTextCommand command){
            var cmd = new MachineCommand(){
                Type = "ShowText",
                Payload = command.Text
            };

            Console.WriteLine($"Trying to send {JsonConvert.SerializeObject(cmd)} to {this.url}");
            
            return this.SendRequest(cmd).Result;
        }

        private async Task<bool> SendRequest(MachineCommand command){
            	try{
                    var client = new HttpClient();
                    var result = await client.PostAsync(url, new StringContent(JsonConvert.SerializeObject(command), Encoding.UTF8, "application/json"));
                
                    return result.StatusCode == HttpStatusCode.OK;
                }
                catch(Exception ex){
                    Console.WriteLine(ex);
                    return false;
                }
        }
    }
}