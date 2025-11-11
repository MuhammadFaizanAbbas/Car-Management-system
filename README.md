# Pristine Shine — Car Detailing Management System
Author: Muhammad Faizan Abbas (with team)  
Technologies: C# (.NET WinForms), MySQL, Python (AI), Mocean SMS API, Inno Setup

## Overview
Pristine Shine is a desktop application for car-detailing studios that provides client management, appointment scheduling, financial reporting and AI-based damage detection. The app runs offline and includes an offline installer.

## How to run (dev)
1. Restore the C# WinForms project in Visual Studio 2022.
2. Import `database/schema.sql` into local MySQL.
3. Setup Python environment for AI module: `python -m venv venv && venv\\Scripts\\activate && pip install -r ai-module/requirements.txt`
4. Run the C# application, configure DB connection in app settings.

## Contents
- backend-csharp/: WinForms source
- ai-module/: damage detection scripts and model
- docs/Pristine_Shine_FYP.pdf: full report

Contact: muhammadfaizanabbas@example.com
