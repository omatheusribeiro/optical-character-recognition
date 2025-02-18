# 📸 Optical Character Recognition

## 📌 Overview
The **Optical Character Recognation (OCR)** is a API built with .NET Core 8. It allows users to upload images via HTTP requests and extracts text using Tesseract OCR. 🚀

This application allows users to: 

✅ **Read text from the image** 🖼️  
✅ **Process the uploaded file** ⚙️  
✅ **Return information to the user** 📦

## 🏗️ Project Structure
```
optical-character-recognition
├── duplicate-photo-check.Api        # Presentation layer (handles HTTP requests)
├── duplicate-photo-check.Service    # Business logic and duplicate detection algorithm
```

## 🚀 Getting Started

### 📋 Prerequisites
Make sure you have the following installed:
- [.NET Core 8 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)

### 🔧 Installation
```bash
# Clone the repository
git clone https://github.com/omatheusribeiro/duplicate-photo-check-bot.git
cd duplicate-photo-check-bot

# Go back to the root directory
cd ..
```

### ▶️ Running the Project

```bash
cd duplicate-photo-check.Api
dotnet run
```

Open your browser and go to: **http://localhost:5180/swagger** 🌐

## ⚙️ How It Works
1. **Send an image through the API.
2. **Receive information read from the image through the response.

## 🛠️ Technologies Used
- **.NET Core 8 (API)**
- **Tesseract OCR**

## 📜 License
This project is licensed under the GPL-3.0 License.

