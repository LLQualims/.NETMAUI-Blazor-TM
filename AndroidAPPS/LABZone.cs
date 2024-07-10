namespace TrackMobile.Models;
public partial class LABZone
{
    public decimal idlabZone { get; set; }
    public string? codeZone { get; set; }
    public string? designationZone { get; set; }
    public byte? typeZone { get; set; }
    public string? auditCRE { get; set; }
    public DateTime? auditDCRE { get; set; }
    public string? auditMOD { get; set; }
    public DateTime? auditDMOD { get; set; }
    public string? enrARCHIVE { get; set; }
    public decimal? idenvPersonnel { get; set; }
    public decimal? boucleZonePrincipale { get; set; }
    public decimal? boucleZoneQuarantaine { get; set; }
    public decimal? idlabDomaine { get; set; }

}
