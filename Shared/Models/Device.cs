using Remotely.Shared.Attributes;
using Remotely.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;

namespace Remotely.Shared.Models
{
    public class Device
    {
        [Sortable]
        [Display(Name = "代理版本")]
        public string AgentVersion { get; set; }

        public ICollection<Alert> Alerts { get; set; }
        [StringLength(100)]

        [Sortable]
        [Display(Name = "别名")]
        public string Alias { get; set; }

        [Sortable]
        [Display(Name = "CPU利用率")]
        public double CpuUtilization { get; set; }

        [Sortable]
        [Display(Name = "当前用户")]
        public string CurrentUser { get; set; }

        public DeviceGroup DeviceGroup { get; set; }
        public string DeviceGroupID { get; set; }

        [Sortable]
        [Display(Name = "设备名称")]
        public string DeviceName { get; set; }
        public List<Drive> Drives { get; set; }

        [Key]
        public string ID { get; set; }

        public bool Is64Bit { get; set; }
        public bool IsOnline { get; set; }

        [Sortable]
        [Display(Name = "最后在线时间")]
        public DateTimeOffset LastOnline { get; set; }

        [StringLength(5000)]
        public string Notes { get; set; }       

        [JsonIgnore]
        public Organization Organization { get; set; }

        public string OrganizationID { get; set; }
        public Architecture OSArchitecture { get; set; }

        [Sortable]
        [Display(Name = "操作系统描述")]
        public string OSDescription { get; set; }

        [Sortable]
        [Display(Name = "平台")]
        public string Platform { get; set; }

        [Sortable]
        [Display(Name = "处理器数量")]
        public int ProcessorCount { get; set; }

        public string PublicIP { get; set; }
        public string ServerVerificationToken { get; set; }

        [JsonIgnore]
        public List<ScriptResult> ScriptResults { get; set; }

        [JsonIgnore]
        public List<ScriptRun> ScriptRuns { get; set; }
        [JsonIgnore]
        public List<ScriptRun> ScriptRunsCompleted { get; set; }

        [JsonIgnore]
        public List<ScriptSchedule> ScriptSchedules { get; set; }

        [StringLength(200)]
        [Sortable]
        [Display(Name = "标签")]
        public string Tags { get; set; } = "";

        [Sortable]
        [Display(Name = "总内存")]
        public double TotalMemory { get; set; }

        [Sortable]
        [Display(Name = "总存储")]
        public double TotalStorage { get; set; }

        [Sortable]
        [Display(Name = "已使用内存")]
        public double UsedMemory { get; set; }

        [Sortable]
        [Display(Name = "内存使用百分比")]
        public double UsedMemoryPercent => UsedMemory / TotalMemory;

        [Sortable]
        [Display(Name = "已使用存储")]
        public double UsedStorage { get; set; }

        [Sortable]
        [Display(Name = "存储使用百分比")]
        public double UsedStoragePercent => UsedStorage / TotalStorage;

        public WebRtcSetting WebRtcSetting { get; set; }
    }
}