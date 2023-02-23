# ZSpace - 2D Unity Planet Shader
 
Fun and versatile shader for Unity URP that can generate stylized 2D planets.
The shader was made with Unity shadergraph in URP, but the compiled .shader file is also available in the Shaders folder.
This was my first attempt at making a shader with the shadergraph so feel free to tell me what I did horribly wrong.

Open the demo scene PlanetExample.unity to see some examples of planets.

# Requirements
* Unity 2022+ with Universal Render Pipeline

## Features
* 3 Levels of noise from full alpha noise, color noise, and alpha cutoff noise.
* Texture2D, Simple, Gradient, Voronoi, and Voronoi Cell available for each layer.
* Versatile, highly customizable, and robust.

## Things To Note
* Alpha noise emission color and color noise don't work together. If using color noise, it will use that color for emission.
* When using the Inverse HV Cutoff option, make sure to adjust the cutoff values accordingly.

## Possible Future Improvements
* Improved shader options
* Shader is large, use of enums in shadergraph really bloats the size
* Clouds deserve their own lightweight version of the shader
* Improved color blending
* Separate shader for Terran planets (shader with a gradient for biome noise)
