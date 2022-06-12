# CSSALTSPINESIM

![39iPigeonUnity_2019 1 1f1_-_ PREVIEW_PACKAGES_IN_USE _-_pro12_06_2022](https://user-images.githubusercontent.com/89361982/173229976-fa6cf115-b7a6-4a3c-b3a4-0cb7265194f6.gif)
<details>
<summary>
6/12/2022 Ultrasound working syringe working , positions localized
</summary>
  
- ### Modifed versions of spine block needle and probe added and aligned
  - orgins alligned in blender, currently i believe there is no way to do it easily in unity
  - i would suggest rotations and and positions be standardized to 0,0,0 and mesh orgins be set to center of volume for easier alignment
- Replaced default ultrasound probe with ultrasound pressure prefab
- updated raycast controller no longer needs tags works based on script objects
- ### raycast controller now triggers ultrasound visualization when it detects a collision
  - works by turning off ultrasound materials when not in contact
  - raycast controller influences classes in SMARTS_SDK.Ultrasound;
- added bone ultrasound material and meshcolider to spinal block
- added skin layer to skin on spinal block
- added ultrasound matrial to needle
</details>
