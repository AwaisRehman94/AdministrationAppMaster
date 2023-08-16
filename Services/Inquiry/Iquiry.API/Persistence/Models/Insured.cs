using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class Insured
{
    public int Id { get; set; }

    public string NationalId { get; set; } = null!;

    public int CardIdTypeId { get; set; }

    public DateTime BirthDate { get; set; }

    public string? BirthDateH { get; set; }

    public int? GenderId { get; set; }

    public string? NationalityCode { get; set; }

    public long? IdIssueCityId { get; set; }

    public string? FirstNameAr { get; set; }

    public string? MiddleNameAr { get; set; }

    public string LastNameAr { get; set; } = null!;

    public string? FirstNameEn { get; set; }

    public string? MiddleNameEn { get; set; }

    public string LastNameEn { get; set; } = null!;

    public int? SocialStatusId { get; set; }

    public int? OccupationId { get; set; }

    public string? ResidentOccupation { get; set; }

    public int EducationId { get; set; }

    public int? ChildrenBelow16Years { get; set; }

    public long? WorkCityId { get; set; }

    public long? CityId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public DateTime? ModifiedDateTime { get; set; }

    public long? UserSelectedWorkCityId { get; set; }

    public long? UserSelectedCityId { get; set; }

    public int? AddressId { get; set; }

    public string? OccupationCode { get; set; }

    public string? OccupationName { get; set; }

    public virtual City? City { get; set; }

    public virtual City? IdIssueCity { get; set; }

    public virtual Occupation? Occupation { get; set; }

    public virtual ICollection<QuotationRequest> QuotationRequests { get; set; } = new List<QuotationRequest>();

    public virtual City? WorkCity { get; set; }
}
