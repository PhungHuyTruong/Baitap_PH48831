using System;
using System.Collections.Generic;

namespace PH48831_phunghuytruong.Models;

public partial class SinhVien
{
    public string Id { get; set; } = null!;

    public string? Ten { get; set; }

    public int? Tuoi { get; set; }

    public string? Nganh { get; set; }

    public string? MaLop { get; set; }

    public virtual LopHoc? MaLopNavigation { get; set; }
}
