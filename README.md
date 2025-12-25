# 🎮 CS_Demo2Vid (GUI Version)

A simple easy to use .NET-based tool to generate multi kill highlight video by round using CS2 demo JSON exports from [CS Demo Manager](https://cs-demo-manager.com/).</br>
<p align="center">
<img width="620" height="396" alt="image" src="https://github.com/user-attachments/assets/4ace0d20-27b9-4514-bb26-33d771a652de" />
 </br>
</p>
⚙️ Multikill Logic
</br></br>

  - 2 Kills  ➤ kills must happen within 384 ticks (≈6s) or be both headshots
  - 3+ Kills ➤ always count as a multikill

🔧 How to Use </br>

✅ 1. Loads .json demo exported from [CS Demo Manager](https://cs-demo-manager.com/). </br>
✅ 2. Choose the output folder for the video. </br>
✅ 3. Pick the player from the dropdown box. </br> 
✅ 4. Double-click any round in the list entry to start generate. </br>
✅ 5. The .mp4 file will be generated in the desired output path/match name/steamId64/round. </br>

<img width="1662" height="316" alt="image" src="https://github.com/user-attachments/assets/e8c62a8e-fdff-4c10-a7e8-047a2381510e" /></br>

🧰 Requirements

  - .Net 10
  - [CS Demo Manager](https://cs-demo-manager.com/)

🚀 Future Ideas

   ☐ Support parsing entire folders of .json files </br>
   ☐ Allow custom tick window threshold </br>
   ☐ Add filter for “headshot-only” rounds </br>

👨‍💻 Credits
  - [CS Demo Manager](https://cs-demo-manager.com/)
    
🧾 License

This project is open source — you can freely modify, reuse, and share for personal purposes.
Please credit the original author if redistributing.
