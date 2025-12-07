# Polygon Visualizer (Çokgen Görselleştirici)


## 🇬🇧 English

### 📘 About the Project
This project was developed as a term assignment for the **SWE 104 Object Oriented Programming** course at **Sakarya University**.

The application serves as an interactive educational tool designed to bridge the gap between abstract mathematical concepts and visual programming. It demonstrates how Object-Oriented Programming (OOP) principles are applied to create, manipulate, and render geometric shapes in a 2D space.

### 🛠️ Technologies Used
* **Programming Language:** C# (C Sharp)
* **IDE:** Visual Studio 2022

### 🌟 Features & Functionality
The application allows users to draw regular polygons by defining specific properties such as the center point, side length, and number of edges. Once drawn, the shape can be customized with real-time RGB color mixing using sliders.

A key feature of the project is the **Transformation Engine**. Users can rotate the polygon by any degree (0-360°) in either Clockwise (CW) or Counter-Clockwise (CCW) directions. During this process, the application calculates and displays the precise $(x, y)$ coordinates for every vertex, visualizing the underlying mathematics of the rotation.
### ⚠️ Project Constraints & Requirements
In accordance with the assignment guidelines, the application enforces specific logical and structural constraints:

* **Center Coordinates:** Inputs for X and Y are restricted to the integer range **[0, 3]**[cite: 37].
* **Edge Length (Radius):** The size of the polygon is limited to values between **[3, 9]**[cite: 39].
* **Number of Edges:** Users can define polygons with a minimum of **3** and a maximum of **10** edges[cite: 59].
* **Rotation Angle:** The rotation logic accepts values between **0° and 359°**[cite: 67].
* **RGB Colors:** Color channels are strictly validated within the standard **[0, 255]** range[cite: 54].
* **Architectural Rule:** The solution strictly adheres to the mandatory 3-class structure (`Point2D`, `ColorRGB`, `Polygon`) as defined in the project sheet[cite: 5, 18, 23].
### 📂 File & Class Structure
The project is architected around core classes to ensure a clean separation of concerns, strictly following OOP guidelines:

* **`Program.cs` :**
    The main entry point of the application. It handles the initial configuration and executes the command to launch the interface, effectively triggering the drawing process and starting the program loop.

* **`Point2D.cs` :**
    This class is the foundation of the coordinate system. It handles the dual nature of 2D points, capable of automatically converting between Cartesian $(x, y)$ and Polar $(r, \theta)$ coordinates. It ensures that every point on the screen has a mathematical definition.

* **`ColorRGB.cs` :**
    This class manages the visual aesthetics. It encapsulates color data, ensuring that Red, Green, and Blue values always stay within the valid 0-255 range. It also includes logic to generate random aesthetic colors for the "Reset" function.

* **`Polygon.cs` :**
    This is the main object class that brings everything together. It uses a `Point2D` for its center and a `ColorRGB` for its appearance. It contains the complex logic required to calculate the position of every vertex based on the number of edges and the radius, as well as the algorithms needed to rotate the shape.

* **`Form1.cs` :**
    This handles the user interaction. It takes inputs from textboxes and sliders, validates them to prevent errors, and calls upon the classes above to render the graphics on the screen.

---

## 🇹🇷 Türkçe

### 📘 Proje Hakkında
Bu proje, **Sakarya Üniversitesi**'nde **SWE 104 Nesne Yönelimli Programlama** dersi kapsamında dönem ödevi olarak geliştirilmiştir.

Uygulama, soyut matematiksel kavramlar ile görsel programlama arasında köprü kurmayı amaçlayan etkileşimli bir eğitim aracıdır. Nesne Yönelimli Programlama (NYP) prensiplerinin, geometrik şekiller oluşturmak, yönetmek ve görselleştirmek için nasıl kullanıldığını uygulamalı olarak gösterir.

### 🛠️ Kullanılan Teknolojiler
* **Programlama Dili:** C#
* **Geliştirme Ortamı:** Visual Studio 2022

### 🌟 Özellikler ve İşlevsellik
Uygulama, kullanıcıların merkez noktası, kenar uzunluğu ve kenar sayısı gibi özellikleri belirleyerek düzenli çokgenler çizmesine olanak tanır. Çizilen şekil, RGB kaydırıcıları kullanılarak anlık renk karışımlarıyla özelleştirilebilir.

Projenin en önemli özelliklerinden biri **Dönüşüm Motoru**dur. Kullanıcılar, oluşturdukları çokgeni istedikleri açıda (0-360°) Saat Yönünde (CW) veya Saat Yönünün Tersine (CCW) döndürebilirler. Bu işlem sırasında uygulama, her bir köşe noktasının yeni $(x, y)$ koordinatlarını hesaplayarak listeler ve dönüşümün arkasındaki matematiği görünür kılar.

### ⚠️ Proje Kısıtlamaları ve Gereksinimler
Uygulama, ödev dosyasında belirtilen yönergelere tam uyum sağlamak adına aşağıdaki mantıksal ve yapısal kısıtlamaları içerir:

* **Merkez Koordinatları:** X ve Y girdileri **[0, 3]** aralığındaki tamsayılarla sınırlandırılmıştır[cite: 37].
* **Kenar Uzunluğu (Yarıçap):** Çokgenin boyutu **[3, 9]** arasındaki değerlerle limitlenmiştir[cite: 39].
* **Kenar Sayısı:** Kullanıcılar en az **3**, en fazla **10** kenarlı çokgenler oluşturabilir[cite: 59].
* **Dönme Açısı:** Döndürme mantığı **0° ile 359°** arasındaki değerleri kabul eder[cite: 67].
* **RGB Renkleri:** Renk kanalları standart **[0, 255]** aralığında doğrulanır[cite: 54].
* **Mimari Kural:** Çözüm, proje dosyasında zorunlu kılınan 3 sınıflı mimariye (`Point2D`, `ColorRGB`, `Polygon`) kesinlikle sadık kalır[cite: 5, 18, 23].

### 📂 Dosya ve Sınıf Yapısı
Proje, temiz kod prensiplerine ve NYP kurallarına uygun olarak ana sınıflar üzerine inşa edilmiştir:

* **`Program.cs` :**
    Uygulamanın ana giriş noktasıdır (Main Entry Point). Gerekli yapılandırmaları yapar ve çizim işlemlerinin gerçekleşeceği arayüzü başlatarak programın çalışmasını tetikler.

* **`Point2D.cs` :**
    Koordinat sisteminin temelidir. 2D noktaların ikili yapısını yönetir; Kartezyen $(x, y)$ ve Kutupsal $(r, \theta)$ koordinatlar arasında otomatik dönüşüm yapar. Ekrandaki her noktanın matematiksel olarak doğru tanımlanmasını sağlar.

* **`ColorRGB.cs` :**
    Görsel estetiği yönetir. Renk verilerini kapsüller ve Kırmızı, Yeşil, Mavi değerlerinin her zaman geçerli (0-255) aralıkta kalmasını garanti eder. Ayrıca "Reset" fonksiyonu için rastgele renkler üretme mantığını içerir.

* **`Polygon.cs` :**
    Diğer parçaları birleştiren ana sınıftır. Merkezi için bir `Point2D` ve rengi için `ColorRGB` sınıfını kullanır. Kenar sayısı ve yarıçapa göre tüm köşe noktalarının konumunu hesaplayan ve şekli döndüren algoritmaları barındırır.

* **`Form1.cs` :**
    Kullanıcı etkileşimini yönetir. Metin kutularından ve kaydırıcılardan gelen verileri alır, hataları önlemek için doğrular ve yukarıdaki sınıfları kullanarak grafikleri ekrana çizer.

---

### 👤 Developer
**Elif Gül Arslan**  
Sakarya University - Software Engineering
