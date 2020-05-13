using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class VDeadLockProcess
    {
        public short Spid { get; set; }
        public short Kpid { get; set; }
        public short Blocked { get; set; }
        public byte[] Waittype { get; set; }
        public long Waittime { get; set; }
        public string Lastwaittype { get; set; }
        public string Waitresource { get; set; }
        public short Dbid { get; set; }
        public short? Uid { get; set; }
        public int Cpu { get; set; }
        public long PhysicalIo { get; set; }
        public int Memusage { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime LastBatch { get; set; }
        public short Ecid { get; set; }
        public short OpenTran { get; set; }
        public string Status { get; set; }
        public byte[] Sid { get; set; }
        public string Hostname { get; set; }
        public string ProgramName { get; set; }
        public string Hostprocess { get; set; }
        public string Cmd { get; set; }
        public string NtDomain { get; set; }
        public string NtUsername { get; set; }
        public string NetAddress { get; set; }
        public string NetLibrary { get; set; }
        public string Loginame { get; set; }
        public byte[] ContextInfo { get; set; }
        public byte[] SqlHandle { get; set; }
        public int StmtStart { get; set; }
        public int StmtEnd { get; set; }
        public int RequestId { get; set; }
    }
}
