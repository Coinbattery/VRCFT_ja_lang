﻿using VRCFaceTracking.Core.Contracts.Services;
using VRCFaceTracking.OSC;

namespace VRCFaceTracking.Core.OSC.Query.mDNS.Types.OscQuery;

public class OscQueryParameterDef : IParameterDefinition
{
    public string Address { get; }
    public string Name { get; }
    public Type Type { get; }

    public OscQueryParameterDef(string address, OSCQueryNode node)
    {
        Address = address;
        Name = node.Name;
        Type = OscUtils.TypeConversions.First(t =>
                t.Key.typeChar
                    .Contains(node.OscType
                        .First()))
            .Key
            .Item1;
    }
}