
# AgroBot – Smart Crop Advisory System 🌾

## 🖥️ Project Type
**Type:** Desktop Application  
**Technologies:** Python (Tkinter / PyQt / Kivy), SQLite, APIs (Weather), ML (optional)

---

## 📌 1. Project Title and Overview
**Title:** AgroBot – Smart Crop Advisory System

AgroBot is a desktop-based smart advisory system designed to assist farmers in making data-driven decisions for better crop selection, resource optimization, and improved yields. By analyzing user-provided data like soil type, weather, and crop history, AgroBot generates personalized agricultural recommendations to empower small and medium-scale farmers.

---

## ❗ 2. Problem Statement

Modern farmers often struggle with unpredictable weather, inconsistent soil quality, and limited access to expert guidance. Most rely on outdated methods or guesswork, leading to low yields and wasted resources. There's a significant gap between agricultural research and real-world farming practices.

AgroBot bridges this gap by providing tailored, real-time suggestions based on farmer-input data, thereby enabling smarter decisions, higher productivity, and better resource management.

---

## ✅ 3. Solution and Scope

### ✔️ Solution

AgroBot processes inputs such as:

- Soil type
- Crop history
- Weather conditions
- Available resources

It then provides suggestions for:

- Optimal crop selection
- Suitable planting and harvesting periods
- Irrigation and fertilization plans
- Basic pest control advice

The application integrates rule-based logic and plans for machine learning modules to generate dynamic, context-aware recommendations.

### 📍 Scope

The initial version will:

- Focus on common crops
- Target regions with basic digital literacy
- Include offline access for areas with poor internet

**Future Enhancements:**
- IoT integration (soil/water sensors)
- Support for more crop types
- Multi-language support

---

## 💡 4. Core Features

- 🌾 **Crop Selection** based on soil, weather, and history
- ☁️ **Weather Integration** via API or manual input
- 🧪 **Soil Type Input** with recommendations
- 📋 **Basic Advisory Engine** (fertilizer, irrigation)
- 🖥️ **Simple, User-Friendly Interface**
- 📶 **Offline Mode** for basic access without internet
- 📝 **Basic Report Generation**
- 📘 **Tutorial Section** for user guidance

---

## 🛠️ 5. Project Plan – Modular Breakdown

| Iteration | Duration | Modules & Features | Deliverables |
|-----------|----------|---------------------|--------------|
| **1** | 2 weeks | - User Auth (Signup/Login) <br> - Data Input Module <br> - Rule-Based Recommendation Engine | Working prototype with registration, data entry, and crop suggestions |
| **2** | 2 weeks | - Weather API Integration <br> - Soil Analyzer <br> - Report Generator | Real-time weather analysis, soil-based advice, and reports |
| **3** | 2 weeks | - Offline Mode <br> - Help Section <br> - UI/UX Enhancements | Fully functional system with offline access and a user guide |

---

## 👥 Team Members

- **Safee Akmal**  
  *Project Lead, Developer, Tester*  
  - Oversees project planning  
  - Develops core modules  
  - Ensures quality and testing  

- **M. Zohaib Shahid**  
  *Requirement Engineer, Architect, Frontend Developer*  
  - Gathers and documents requirements  
  - Designs system architecture  
  - Builds the user interface  

---

## 📷 Screenshots (Optional)
_Add screenshots of your UI here when available._

---

## 🗂️ Folder Structure (Suggested)

```

AgroBot/
│
├── src/                     # Source code
│   ├── ui/                  # UI components
│   ├── logic/               # Recommendation engine
│   ├── data/                # Static data (crop info, etc.)
│   └── db/                  # Local database
│
├── assets/                 # Icons, images
├── README.md
├── requirements.txt
└── LICENSE

````

---

## 📦 Requirements

- Python 3.x
- Tkinter / PyQt5 / Kivy
- `requests` (for weather API)
- SQLite3

Install dependencies with:

```bash
pip install -r requirements.txt
````

---

## 🚀 Getting Started

```bash
git clone https://github.com/zohaib-7035/AgroBot-Agricultural-Prediction-and-Recommendation-System.git
cd AgroBot
python main.py
```

---

## 📃 License

This project is licensed under the MIT License.
Feel free to modify and use for educational purposes.

---

## 🤝 Acknowledgements

* Farmers who inspired the problem
* OpenWeatherMap API
* Open-source agronomy datasets

```


