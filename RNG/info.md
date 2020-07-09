## RadomEntityGenerator
1. RNG:
  * order of drawing of the components:
    - first generate the temperature. *Desired value: __EarthLike__*
    - then we generate the size: *Desired value: __EarthLike__*
    - next up, the atmosphere: *Desired value: __EarthLike__*
    - followed by gravity: *Desired value: __EarthLike__*
    - now, the water: *Desired value: __Liquid__*
    - next, flora: *Desired value: __Edible__*
    - then, fauna: *Desired value: __Mammals__*
    - lastly, civilization: *Desired value: __PlanetaryUnions__*
  * assumptions: *as we search for a habitable planet for humans, the process of generating a planet must conform to some rules.</br> 
    Each rule described above contains the desired value for the player. Info about habitable exoplanets from NASA (here)[https://exoplanets.nasa.gov/what-is-an-exoplanet/how-do-we-find-habitable-planets/]*
  - The __temperature__ is the most important factor. It shows the habitable zone. Affected properties' ranges for each type of temperature:
    * __Freezing__:
      - water: *{None, Trace, Glaciers}*
      - flora: *{None}*
      - fauna: *{None}*
      - civilization: *{None}*
    * __Cold__:
      - water: *{None, Trace, Liquid, Glaciers}*
      - flora: *{None, Autotrophs}*
      - fauna: *{None, Microorganisms}*
      - civilization: *{None, Ruined}*
    * __EarthLike__: cool and good, everything may happen!
    * __Hot__:
      - water: *{None, Trace, Liquid, PlanetWideOcean}*
    * __Lethal__:
      - water: *{None, Trace}*
      - flora: *{None, Autotrophs}*
      - fauna: *{None, Microorganisms}*
      - civilization: *{None, Ruined}*
  - Next, the __size__. Gravity and atmosphere depend on size. But lemme just stick to the gravity now.
    * __Dwarf__:
      - gravity: *{Weak, MarsLike}*
    * __SubTerrestrial__:
      - gravity: *{MarsLike, EarthLike}*
    * __Terrestrial__:
      - gravity: *{EarthLike, NeptuneLike}*
    * __SuperTerrestrial__:
      - gravity: *{NeptuneLike, JupiterLike}*
    * __Giant__:
      - gravity: *{JupiterLike}*
  - The __gravity__ affects the atmosphere. If it's too strong or to weak, it may affect other spheres. For now we'll stick to atmosphere.
    * __Weak__:
      - atmosphere: *{None}*
    * __MarsLike__:
      - atmosphere: *{None, Trace}*
    * __EarthLike__:
      - atmosphere: *{None, Trace, EarthLike, Toxic}*
    * __NeptuneLike__:
      - all
    * __JupiterLike__:
      - all
  - __WaterResourceType__ is needed for organisms. At least ones we are accustomed to. Didn't you have przyrka at school?
    * __None__:
      - fauna, flora *{None}*
      - civilization: *{None, Ruined}*
    * __Trace__:
    * __Liquid__:
    * __Glaciers__:
      - flora: *{None, Autotrophs}*
      - fauna: *{None, Microorganisms}*
    * __PlanetWideOcean__:
  - The rest of properties are not chained in such relations. *I can't wait for a reptilian, planetary union.*