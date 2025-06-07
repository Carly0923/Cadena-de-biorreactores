﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentResults;
using System.Net;
using Dominio_Fermentación.Common;
using Dominio_Fermentación.Errors;
using Dominio_Fermentación.Rules;

namespace Dominio_Fermentación.ValueObjects
{
  /// <summary> Dirección en una red informática. </summary>
  public class NetworkAddress
   : ValueObject
  {
   #region Properties
   /// <summary> Dirección IP. </summary>
   public string IPAddress { get; }
   /// <summary> Puerto de acceso. </summary>
   public int Port { get; }
   #endregion
    private NetworkAddress(string iPAddress, int port)
    {
     IPAddress = iPAddress;
     Port = port;
    }
    public static Result<NetworkAddress> Create(string iPAddress,int port)
    {
     var result = CheckRules(
          new IPAddressMustHaveFourSeparators(iPAddress),
          new IPAddressMustHaveValidValues(iPAddress),
          new PortMustBeInAValidRange(port));
       if (result.IsFailed)
           return result.ToResult<NetworkAddress>();

       return Result.Ok(new NetworkAddress(iPAddress, port));
    }
    protected override IEnumerable<object> GetEqualityComponents()
    {
      return new object[] { IPAddress, Port };
    }
  }
}