﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.Entities.LogEntities;

public partial class Log
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public string Thread { get; set; }

    public string Level { get; set; }

    public string Logger { get; set; }

    public string Message { get; set; }

    public string Exception { get; set; }

    public string ReferenceId { get; set; }
}