using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class Vehicle
{
    public Guid Id { get; set; }

    public string? SequenceNumber { get; set; }

    public string? CustomCardNumber { get; set; }

    public byte? Cylinders { get; set; }

    public string? LicenseExpiryDate { get; set; }

    public string? MajorColor { get; set; }

    public string? MinorColor { get; set; }

    public short? ModelYear { get; set; }

    public byte? PlateTypeCode { get; set; }

    public string? RegisterationPlace { get; set; }

    public byte VehicleBodyCode { get; set; }

    public int VehicleWeight { get; set; }

    public int VehicleLoad { get; set; }

    public string? VehicleMaker { get; set; }

    public string VehicleModel { get; set; } = null!;

    public string? ChassisNumber { get; set; }

    public short? VehicleMakerCode { get; set; }

    public long? VehicleModelCode { get; set; }

    public bool IsDeleted { get; set; }

    public string? CarPlateText1 { get; set; }

    public string? CarPlateText2 { get; set; }

    public string? CarPlateText3 { get; set; }

    public short? CarPlateNumber { get; set; }

    public string? CarOwnerNin { get; set; }

    public string? CarOwnerName { get; set; }

    public int? VehicleValue { get; set; }

    public bool? IsUsedCommercially { get; set; }

    public bool OwnerTransfer { get; set; }

    public int? EngineSizeId { get; set; }

    public int VehicleUseId { get; set; }

    public decimal? CurrentMileageKm { get; set; }

    public int? MileageExpectedAnnualId { get; set; }

    public int? ParkingLocationId { get; set; }

    public int? TransmissionTypeId { get; set; }

    public int? AxleWeightId { get; set; }

    public bool HasModifications { get; set; }

    public string? ModificationDetails { get; set; }

    public int VehicleIdTypeId { get; set; }

    public int? BrakeSystemId { get; set; }

    public int? CruiseControlTypeId { get; set; }

    public int? ParkingSensorId { get; set; }

    public int? CameraTypeId { get; set; }

    public bool? HasAntiTheftAlarm { get; set; }

    public bool? HasFireExtinguisher { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public long? ColorCode { get; set; }

    public bool? ManualEntry { get; set; }

    public string? MissingFields { get; set; }

    public bool HasTrailer { get; set; }

    public int TrailerSumInsured { get; set; }

    public bool OtherUses { get; set; }

    public virtual ICollection<CheckoutDetail> CheckoutDetails { get; set; } = new List<CheckoutDetail>();

    public virtual VehiclePlateType? PlateTypeCodeNavigation { get; set; }

    public virtual ICollection<QuotationRequest> QuotationRequests { get; set; } = new List<QuotationRequest>();

    public virtual VehicleBodyType VehicleBodyCodeNavigation { get; set; } = null!;

    public virtual ICollection<VehicleSpecification> VehicleSpecifications { get; set; } = new List<VehicleSpecification>();
}
