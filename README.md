# OmniPerspect: Unity-side

[![Video Demonstration](/images/video_sumnail.png)](https://www.youtube.com/shorts/YI32PZjzeMI)  
[Check out the Blog!](https://rubaduckduck.github.io/2024/07/20/omni_perspect.html)   
[Python-side Github](https://github.com/RubADuckDuck/Binocular-Position-Retreival)

A simple Unity project that displays 3D position data from a binocular camera tracking system.

## Overview

This Unity project provides components to visualize position data tracked by the BNC Tracker Python system. It includes camera projection techniques to render content from the correct perspective based on tracked positions, enabling more immersive interactive experiences.

## Key Components

- **Projection System**: Specialized camera rendering for perspective-correct displays
- **Tracking Integration**: Components for connecting with the BNC Tracker Python system
- **Test Tools**: Manual keyboard and automatic trackers for testing without external data
- **Visualization Helpers**: Gizmos and debug tools for setup and calibration

## Getting Started

1. Clone this repository
2. Open in Unity 2020.3 or newer
3. Open the sample scene in `Assets/Scenes/`
4. Configure the tracking connection in the BinocularCameraManager component

## Python Integration

This project is designed to work with the BNC Tracker Python system, which performs the actual camera processing and 3D position calculation.

- **Python Tracker**: [Python-side Github](https://github.com/RubADuckDuck/Binocular-Position-Retreival)
- **Implementation Details**: [link to blog](https://rubaduckduck.github.io/2024/07/20/omni_perspect.html)   

## Configuration

The BinocularCameraManager component serves as the primary integration point with the Python tracking system. It receives position data and scales it appropriately for the Unity scene.

