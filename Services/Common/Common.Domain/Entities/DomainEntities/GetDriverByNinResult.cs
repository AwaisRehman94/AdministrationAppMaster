﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Domain.DomainEntities.Entities.DomainEntities
{
    public partial class GetDriverByNinResult
    {
        public Guid DriverId { get; set; }
        public bool IsCitizen { get; set; }
        public string EnglishFirstName { get; set; }
        public string EnglishLastName { get; set; }
        public string EnglishSecondName { get; set; }
        public string EnglishThirdName { get; set; }
        public string LastName { get; set; }
        public string SecondName { get; set; }
        public string FirstName { get; set; }
        public string ThirdName { get; set; }
        public string SubtribeName { get; set; }
        public DateTime? DateOfBirthG { get; set; }
        public short? NationalityCode { get; set; }
        public string DateOfBirthH { get; set; }
        public string NIN { get; set; }
        public bool? IsSpecialNeed { get; set; }
        public string IdIssuePlace { get; set; }
        public string IdExpiryDate { get; set; }
        public bool IsDeleted { get; set; }
        public int? ViolationId { get; set; }
        public int? OccupationId { get; set; }
        public string ResidentOccupation { get; set; }
        public int GenderId { get; set; }
        public int? SocialStatusId { get; set; }
        public int? MedicalConditionId { get; set; }
        public int? DrivingPercentage { get; set; }
        public int EducationId { get; set; }
        public int? ChildrenBelow16Years { get; set; }
        public long? CityId { get; set; }
        public long? WorkCityId { get; set; }
        public int? NOALast5Years { get; set; }
        public int? NOCLast5Years { get; set; }
        public int? NCDFreeYears { get; set; }
        public string NCDReference { get; set; }
        public int? MaritalStatusCode { get; set; }
        public int? NumOfChildsUnder16 { get; set; }
        public int? DrivingLicenseTypeCode { get; set; }
        public int? SaudiLicenseHeldYears { get; set; }
        public int? EligibleForNoClaimsDiscountYears { get; set; }
        public int? NumOfFaultAccidentInLast5Years { get; set; }
        public int? NumOfFaultclaimInLast5Years { get; set; }
        public string RoadConvictions { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CityName { get; set; }
        public int? AddressId { get; set; }
        public string WorkCityName { get; set; }
        public string OccupationName { get; set; }
        public string EducationName { get; set; }
        public string SocialStatusName { get; set; }
        public string PostCode { get; set; }
        public string ExtraLicenses { get; set; }
        public string Licenses { get; set; }
        public string Violations { get; set; }
        public string OccupationCode { get; set; }
        public int? RelationShipId { get; set; }
        public string MobileNumber { get; set; }
    }
}