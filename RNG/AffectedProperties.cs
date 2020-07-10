using System;
using System.Collections.Generic;
using The_Ark.enums;

namespace The_Ark.RNG.EntityGenerator
{
    public partial class RandomEntityGenerator
    {
        private readonly static Dictionary<Enum, ICollection<Enum>> _affectedProperties = new Dictionary<Enum, ICollection<Enum>>()
        {
            //affected by temperature
            {
                TemperatureType.Freezing,
                new List<Enum>
                {
                    //water
                    WaterResourceType.None,
                    WaterResourceType.Trace,
                    WaterResourceType.Glaciers,
                    //flora
                    FloraType.None,
                    //fauna
                    FaunaType.None,
                    //civ
                    CivilizationType.None
                }
            },
            {
                TemperatureType.Cold,
                new List<Enum>
                {
                    //water
                    WaterResourceType.None,
                    WaterResourceType.Trace,
                    WaterResourceType.Liquid,
                    WaterResourceType.Glaciers,
                    //flora
                    FloraType.None,
                    FloraType.Autotrophs,
                    //fauna
                    FaunaType.None,
                    FaunaType.Microorganisms,
                    //civ
                    CivilizationType.None,
                    CivilizationType.Ruined
                }
            },
            {
                TemperatureType.EarthLike,
                new List<Enum>
                {
                    //all the properties
                    //water
                    WaterResourceType.None,
                    WaterResourceType.Trace,
                    WaterResourceType.Liquid,
                    WaterResourceType.Glaciers,
                    WaterResourceType.PlanetWideOcean,
                    //flora
                    FloraType.None,
                    FloraType.Autotrophs,
                    FloraType.Unedible,
                    FloraType.Edible,
                    FloraType.Poisonous,
                    //fauna
                    FaunaType.None,
                    FaunaType.Microorganisms,
                    FaunaType.Insects,
                    FaunaType.Reptiles,
                    FaunaType.Mammals,
                    //civ
                    CivilizationType.None,
                    CivilizationType.Tribal,
                    CivilizationType.Agricultural,
                    CivilizationType.Kingdoms,
                    CivilizationType.States,
                    CivilizationType.PlanetaryUnions,
                    CivilizationType.Ruined
                }
            },
            {
                TemperatureType.Hot,
                new List<Enum>
                {
                    //water
                    WaterResourceType.None,
                    WaterResourceType.Trace,
                    WaterResourceType.Liquid,
                    WaterResourceType.PlanetWideOcean,
                    //flora
                    FloraType.None,
                    FloraType.Autotrophs,
                    FloraType.Unedible,
                    FloraType.Edible,
                    FloraType.Poisonous,
                    //fauna
                    FaunaType.None,
                    FaunaType.Microorganisms,
                    FaunaType.Insects,
                    FaunaType.Reptiles,
                    FaunaType.Mammals,
                    //civ
                    CivilizationType.None,
                    CivilizationType.Tribal,
                    CivilizationType.Agricultural,
                    CivilizationType.Kingdoms,
                    CivilizationType.States,
                    CivilizationType.PlanetaryUnions,
                    CivilizationType.Ruined
                }
            },
            {
                TemperatureType.Lethal,
                new List<Enum>
                {
                    //water
                    WaterResourceType.None,
                    WaterResourceType.Trace,
                    //flora
                    FloraType.None,
                    FloraType.Autotrophs,
                    //fauna
                    FaunaType.None,
                    FaunaType.Microorganisms,
                    //civ
                    CivilizationType.None,
                    CivilizationType.Ruined
                }
            },
            //affected by size
            {
                SizeType.Dwarf,
                new List<Enum>
                {
                    GravityType.Weak,
                    GravityType.MarsLike
                }
            },
            {
                SizeType.SubTerrestrial,
                new List<Enum>
                {
                    GravityType.MarsLike,
                    GravityType.EarthLike
                }
            },
            {
                SizeType.Terrestrial,
                new List<Enum>
                {
                    GravityType.EarthLike,
                    GravityType.NeptuneLike
                }
            },
            {
                SizeType.SuperTerrestrial,
                new List<Enum>
                {
                    GravityType.NeptuneLike,
                    GravityType.JupiterLike
                }
            },
            {
                SizeType.Giant,
                new List<Enum>
                {
                    GravityType.JupiterLike
                }
            },
            //affected by gravity
            {
                GravityType.Weak,
                new List<Enum>
                {
                    AtmosphereType.None
                }
            },
            {
                GravityType.MarsLike,
                new List<Enum>
                {
                    AtmosphereType.None,
                    AtmosphereType.Trace
                }
            },
            {
                GravityType.EarthLike,
                new List<Enum>
                {
                    AtmosphereType.None,
                    AtmosphereType.Trace,
                    AtmosphereType.EarthLike,
                    AtmosphereType.Toxic
                }
            },
            {
                GravityType.NeptuneLike,
                new List<Enum>
                {
                    //Neptune- and Jupiter- are equal, coz why not.
                    //they are heavy bois
                    AtmosphereType.None,
                    AtmosphereType.Trace,
                    AtmosphereType.EarthLike,
                    AtmosphereType.Thick,
                    AtmosphereType.Toxic
                }
            },
            {
                GravityType.JupiterLike,
                new List<Enum>
                {
                    AtmosphereType.None,
                    AtmosphereType.Trace,
                    AtmosphereType.EarthLike,
                    AtmosphereType.Thick,
                    AtmosphereType.Toxic
                }
            },
            //affected by water resource
            {
                WaterResourceType.None,
                new List<Enum>
                {
                    FaunaType.None,
                    FloraType.None,
                    CivilizationType.None,
                    CivilizationType.Ruined
                }
            },
            {
                WaterResourceType.Trace,
                new List<Enum>
                {
                    FloraType.None,
                    FloraType.Autotrophs,
                    FloraType.Unedible,
                    FloraType.Edible,
                    FloraType.Poisonous,
                    //fauna
                    FaunaType.None,
                    FaunaType.Microorganisms,
                    FaunaType.Insects,
                    FaunaType.Reptiles,
                    FaunaType.Mammals,
                    //civ
                    CivilizationType.None,
                    CivilizationType.Tribal,
                    CivilizationType.Agricultural,
                    CivilizationType.Kingdoms,
                    CivilizationType.States,
                    CivilizationType.PlanetaryUnions,
                    CivilizationType.Ruined
                }
            },
            {
                WaterResourceType.Liquid,
                new List<Enum>
                {
                    FloraType.None,
                    FloraType.Autotrophs,
                    FloraType.Unedible,
                    FloraType.Edible,
                    FloraType.Poisonous,
                    //fauna
                    FaunaType.None,
                    FaunaType.Microorganisms,
                    FaunaType.Insects,
                    FaunaType.Reptiles,
                    FaunaType.Mammals,
                    //civ
                    CivilizationType.None,
                    CivilizationType.Tribal,
                    CivilizationType.Agricultural,
                    CivilizationType.Kingdoms,
                    CivilizationType.States,
                    CivilizationType.PlanetaryUnions,
                    CivilizationType.Ruined
                }
            },
            {
                WaterResourceType.Glaciers,
                new List<Enum>
                {
                    //a planetary union of fungi gonna be rad
                    FloraType.None,
                    FloraType.Autotrophs,
                    //fauna
                    FaunaType.None,
                    FaunaType.Microorganisms,
                    //civ
                    CivilizationType.None,
                    CivilizationType.Tribal,
                    CivilizationType.Agricultural,
                    CivilizationType.Kingdoms,
                    CivilizationType.States,
                    CivilizationType.PlanetaryUnions,
                    CivilizationType.Ruined
                }
            },
            {
                WaterResourceType.PlanetWideOcean,
                new List<Enum>
                {
                    FloraType.None,
                    FloraType.Autotrophs,
                    FloraType.Unedible,
                    FloraType.Edible,
                    FloraType.Poisonous,
                    //fauna
                    FaunaType.None,
                    FaunaType.Microorganisms,
                    FaunaType.Insects,
                    FaunaType.Reptiles,
                    FaunaType.Mammals,
                    //civ
                    CivilizationType.None,
                    CivilizationType.Tribal,
                    CivilizationType.Agricultural,
                    CivilizationType.Kingdoms,
                    CivilizationType.States,
                    CivilizationType.PlanetaryUnions,
                    CivilizationType.Ruined
                }
            },
        };
    }
}