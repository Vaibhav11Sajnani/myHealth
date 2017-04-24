using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHealth.Models
{
    public class Project
    {
        public class Widget
        {
            public string type { get; set; }
            public int id { get; set; }
            public int x { get; set; }
            public int y { get; set; }
            public int color { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int tabId { get; set; }
            public bool isEnabled { get; set; }
            public int deviceId { get; set; }
            public int pin { get; set; }
            public bool pwmMode { get; set; }
            public bool rangeMappingOn { get; set; }
            public int min { get; set; }
            public int max { get; set; }
            public int frequency { get; set; }
            public bool isBar { get; set; }
        }

        

        public class HardwareInfo
        {
            public string version { get; set; }
            public string boardType { get; set; }
            public string cpuType { get; set; }
            public string connectionType { get; set; }
            public string buildDate { get; set; }
            public int heartbeatInterval { get; set; }
        }

        


    public int id { get; set; }
    public int parentId { get; set; }
    public bool isPreview { get; set; }
    public string name { get; set; }
    public long createdAt { get; set; }
    public long updatedAt { get; set; }
    public List<Widget> widgets { get; set; }
    public List<Device> devices { get; set; }
    public string theme { get; set; }
    public bool keepScreenOn { get; set; }
    public bool isAppConnectedOn { get; set; }
    public bool isShared { get; set; }
    public bool isActive { get; set; }
    public HardwareInfo hardwareInfo { get; set; }
    public PinsStorage pinsStorage { get; set; }

    }
}
