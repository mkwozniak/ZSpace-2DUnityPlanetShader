# ZSpace - 2D Unity Planet Shader
 
Fun and versatile shader for Unity URP that can generate stylized 2D planets.
The shader was made with Unity shadergraph in URP, but the compiled .shader file is also available in the Shaders folder.
This was my first attempt at making a shader with the shadergraph so feel free to tell me what I did horribly wrong.

Open the demo scene PlanetExample.unity to see the more lively examples of planets.

## Screenshots
<details>
  <summary>Terran</summary> 
  
![image](https://user-images.githubusercontent.com/51724102/220834703-f3bb3cb1-71d5-4ff5-8116-16745fc710c9.png)
</details>

<details>
  <summary>Rocky Volcanic</summary> 
  
![image](https://user-images.githubusercontent.com/51724102/220834801-281b967a-9bbf-4751-8727-108adf97de7b.png)
</details>

<details>
  <summary>Gas Giant</summary> 
  
![image](https://user-images.githubusercontent.com/51724102/220834852-498f0f06-9e4b-4b1c-9407-1a6646cf9d48.png)
</details>

<details>
  <summary>Moon</summary> 
  
![image](https://user-images.githubusercontent.com/51724102/220835828-a19febd0-78cf-4865-b0dc-4de1e5741b25.png)

</details>

<details>
  <summary>Desert</summary> 
  
![image](https://user-images.githubusercontent.com/51724102/220835940-cc193305-a636-47c1-8b99-57002d95bd85.png)

</details>

<details>
  <summary>Molten</summary> 
  
![image](https://user-images.githubusercontent.com/51724102/220836005-1194d29f-de6d-4467-b73f-53cfcf861b76.png)

</details>

More examples are in the demo scene.

## Requirements
* Unity 2021+ with Universal Render Pipeline

## Features
* 3 Levels of noise from full alpha noise, color noise, and alpha cutoff noise.
* Texture2D, Simple, Gradient, Voronoi, and Voronoi Cell available for each layer.
* Versatile, highly customizable, and robust.

## How To Use
There are four main categories of the shader, each with their own options.

### Alpha Noise
Alpha Noise applies an alpha cutoff noise pattern to the entire sprite.

### Color Noise
Color noise applies a colored noise pattern on top of that. 
The secondary color determines the inverse color of the noise pattern.

### Overlay Texture
Overlays another texture on top of the entire sprite.
This is used in the examples to apply a fading effect around the edges of the planet.

### HV Cutoff
HV Cutoff applies an alpha cutoff on the horizontal and vertical UVs.
A noise pattern can be applied to this cutoff as well.

## Things To Note
* Alpha noise emission color and color noise don't work together. If using color noise, it will use that color for emission.
* When using the Inverse HV Cutoff option, make sure to adjust the cutoff values accordingly.

## Known Issues
* The final .shader version does not show the separate categories.
* The HV Cut noise step value isn't working as intended

## Possible Future Improvements
* Improved shader options
* Shader is large, use of enums in shadergraph really bloats the size
* Clouds deserve their own lightweight version of the shader
* Improved color blending
* Separate shader for Terran planets (shader with a gradient for biome noise)
