using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace import_fsa;

[Table("ral_short_info")]
public class RalShort
{
    [Column("link")] 
    [StringLength(128)]
    public string Link { get; set; }
    
    [StringLength(128)]
    public string RegNumber { get; set; }
    
    [Column("old_status_AL")]
    [StringLength(128)]
    public string? Old_status_AL { get; set; }
    
    [Column("new_status_AL")]
    [StringLength(128)]
    public string? New_status_AL { get; set; }
    
    [Column("status_change_date")]
    public DateTime? Status_change_date { get; set; }
    
    [Column("nameType")]
    [StringLength(128)]
    public string NameType { get; set; }
    
    [Column("nameTypeActivity")]
    [StringLength(256)]
    public string? NameTypeActivity { get; set; }
    
    [Column("regDate")]
    [StringLength(128)]
    public string? RegDateStr { get; set; }
    
    [Column("fullName")]
    [StringLength(512)]
    public string? FullName { get; set; }
    
    [Column("address")]
    [StringLength(4096)]
    public string? Address { get; set; }
    
    [Column("applicantINN")]
    [StringLength(32)]
    public string? ApplicantINN { get; set; }
    
    [Column("applicantFullName")]
    [StringLength(1024)]
    public string? ApplicantFullName { get; set; }
    
    [Column("oaDescription")]
    public string? OaDescription { get; set; }
    
    [Column("NPstatus")]
    [StringLength(128)]
    public string? NPstatus { get; set; }

    [Column("id")]
    public int Id { get; set; }
}