using System;
using System.Collections.Generic;

namespace PH48831_phunghuytruong.Models;

public partial class LopHoc
{
    public string MaLop { get; set; } = null!;

    public string? TenLop { get; set; }

    public int? Khoa { get; set; }

    public virtual ICollection<SinhVien> SinhViens { get; set; } = new List<SinhVien>();
}
