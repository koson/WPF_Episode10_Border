# สคริปต์การสอน: WPF Episode 10 - Border

## เนื้อหาที่จะสอน

### 1. Border คืออะไร
- Control สำหรับสร้างกรอบและพื้นหลัง
- ห่อหุ้ม Element อื่นๆ
- รองรับมุมมน (CornerRadius)

### 2. Border Properties
- BorderBrush - สีของกรอบ
- BorderThickness - ความหนาของกรอบ
- CornerRadius - มุมมน
- Padding - ระยะห่างภายใน
- Background - สีพื้นหลัง

### 3. การใช้งาน
- สร้างกรอบรอบ Element
- Card Design
- Panel แยกส่วน
- Button/TextBox Custom

---

## ส่วนที่ 1: Introduction (0:00 - 2:00)

**สวัสดีครับทุกคน**

ยินดีต้อนรับกลับมาสู่ WPF Tutorial Series ของเรา

วันนี้เราจะมาเรียนรู้เกี่ยวกับ **Border** ซึ่งเป็น Control พื้นฐานแต่สำคัญมาก!

Border ใช้สำหรับ:
- สร้างกรอบรอบ Element
- เพิ่มพื้นหลัง
- ทำมุมมน (Rounded Corners)
- สร้าง Card Design

**Border ทำให้ UI สวยขึ้นเยอะเลย!**

---

## ส่วนที่ 2: Border พื้นฐาน (2:00 - 6:00)

### Demo 2.1: Border ง่ายๆ

```xml
<Border BorderBrush="Black" 
        BorderThickness="2">
    <TextBlock Text="Hello Border!"/>
</Border>
```

**อธิบาย:**
- `BorderBrush="Black"` - สีกรอบสีดำ
- `BorderThickness="2"` - กรอบหนา 2 pixels
- Border ห่อหุ้ม TextBlock

### Demo 2.2: เพิ่ม Background และ Padding

```xml
<Border BorderBrush="Blue" 
        BorderThickness="2"
        Background="LightBlue"
        Padding="20">
    <TextBlock Text="Border with Background and Padding"/>
</Border>
```

**อธิบาย:**
- `Background="LightBlue"` - สีพื้นหลัง
- `Padding="20"` - ระยะห่างภายใน 20 pixels
- TextBlock ห่างจากกรอบ

### Demo 2.3: ทำไมต้องใช้ Border?

**ไม่มี Border:**
```xml
<TextBlock Text="No Border" Background="LightGray"/>
```

**มี Border:**
```xml
<Border BorderBrush="Gray" 
        BorderThickness="1"
        Background="LightGray"
        Padding="10">
    <TextBlock Text="With Border"/>
</Border>
```

เห็นความแตกต่างไหมครับ? Border ช่วยให้ดูเป็นระเบียบมากขึ้น!

---

## ส่วนที่ 3: BorderBrush และ BorderThickness (6:00 - 10:00)

### Demo 3.1: BorderBrush - สีกรอบ

```xml
<StackPanel Orientation="Horizontal">
    <Border BorderBrush="Red" BorderThickness="2" 
            Padding="10" Margin="5">
        <TextBlock Text="Red Border"/>
    </Border>
    
    <Border BorderBrush="Blue" BorderThickness="2" 
            Padding="10" Margin="5">
        <TextBlock Text="Blue Border"/>
    </Border>
    
    <Border BorderBrush="Green" BorderThickness="2" 
            Padding="10" Margin="5">
        <TextBlock Text="Green Border"/>
    </Border>
</StackPanel>
```

### Demo 3.2: BorderThickness - ความหนา

```xml
<StackPanel Orientation="Horizontal">
    <Border BorderBrush="Black" BorderThickness="1" 
            Padding="10" Margin="10">
        <TextBlock Text="Thin (1px)"/>
    </Border>
    
    <Border BorderBrush="Black" BorderThickness="3" 
            Padding="10" Margin="10">
        <TextBlock Text="Medium (3px)"/>
    </Border>
    
    <Border BorderBrush="Black" BorderThickness="5" 
            Padding="10" Margin="10">
        <TextBlock Text="Thick (5px)"/>
    </Border>
</StackPanel>
```

### Demo 3.3: BorderThickness แบบ Asymmetric

Border รองรับการกำหนดความหนาแต่ละด้าน!

**รูปแบบ:** Left, Top, Right, Bottom

```xml
<StackPanel>
    <!-- เฉพาะด้านซ้าย -->
    <Border BorderBrush="Purple" 
            BorderThickness="5,0,0,0" 
            Padding="15,10" Margin="10">
        <TextBlock Text="Left Border Only"/>
    </Border>
    
    <!-- เฉพาะด้านล่าง -->
    <Border BorderBrush="Orange" 
            BorderThickness="0,0,0,5" 
            Padding="15,10" Margin="10">
        <TextBlock Text="Bottom Border Only"/>
    </Border>
    
    <!-- Custom Mix -->
    <Border BorderBrush="Teal" 
            BorderThickness="2,5,2,0" 
            Padding="15,10" Margin="10">
        <TextBlock Text="Top Thick, Others Thin"/>
    </Border>
</StackPanel>
```

**เทคนิค:** มักใช้ Bottom Border สำหรับ Underline Effect!

---

## ส่วนที่ 4: CornerRadius - มุมมน (10:00 - 15:00)

### Demo 4.1: CornerRadius พื้นฐาน

```xml
<StackPanel Orientation="Horizontal">
    <Border BorderBrush="Red" BorderThickness="2" 
            CornerRadius="5" 
            Padding="10" Margin="10">
        <TextBlock Text="Radius: 5"/>
    </Border>
    
    <Border BorderBrush="Blue" BorderThickness="2" 
            CornerRadius="15" 
            Padding="10" Margin="10">
        <TextBlock Text="Radius: 15"/>
    </Border>
    
    <Border BorderBrush="Green" BorderThickness="2" 
            CornerRadius="25" 
            Padding="10" Margin="10">
        <TextBlock Text="Radius: 25"/>
    </Border>
</StackPanel>
```

**CornerRadius ยิ่งมาก = มุมยิ่งมน!**

### Demo 4.2: CornerRadius แบบ Asymmetric

CornerRadius รองรับกำหนดแต่ละมุมได้!

**รูปแบบ:** TopLeft, TopRight, BottomRight, BottomLeft

```xml
<StackPanel Orientation="Horizontal">
    <!-- มุมบนซ้ายอย่างเดียว -->
    <Border BorderBrush="Purple" BorderThickness="2" 
            CornerRadius="20,0,0,0" 
            Background="Lavender"
            Padding="15" Margin="10">
        <TextBlock Text="Top-Left"/>
    </Border>
    
    <!-- มุมบนทั้งสองด้าน -->
    <Border BorderBrush="Orange" BorderThickness="2" 
            CornerRadius="20,20,0,0" 
            Background="Wheat"
            Padding="15" Margin="10">
        <TextBlock Text="Top Rounded"/>
    </Border>
    
    <!-- มุมล่างทั้งสองด้าน -->
    <Border BorderBrush="Teal" BorderThickness="2" 
            CornerRadius="0,0,20,20" 
            Background="LightCyan"
            Padding="15" Margin="10">
        <TextBlock Text="Bottom Rounded"/>
    </Border>
</StackPanel>
```

### Demo 4.3: Pill Shape (ปุ่มแบบเม็ดยา)

```xml
<Border BorderBrush="DodgerBlue" 
        BorderThickness="2" 
        CornerRadius="50" 
        Background="LightSkyBlue"
        Padding="30,10" 
        Margin="10">
    <TextBlock Text="Pill Button" 
               FontWeight="Bold" 
               HorizontalAlignment="Center"/>
</Border>
```

CornerRadius สูงๆ = Pill Shape!

---

## ส่วนที่ 5: Background - พื้นหลัง (15:00 - 20:00)

### Demo 5.1: Solid Color Background

```xml
<Border BorderBrush="Black" BorderThickness="2" 
        CornerRadius="10"
        Background="LightGreen"
        Padding="20">
    <TextBlock Text="Solid Color Background"/>
</Border>
```

### Demo 5.2: Gradient Background - Linear

```xml
<Border BorderBrush="Blue" BorderThickness="2" 
        CornerRadius="10" Padding="20" Margin="10">
    <Border.Background>
        <LinearGradientBrush StartPoint="0,0" EndPoint="1,1">
            <GradientStop Color="#3498DB" Offset="0"/>
            <GradientStop Color="#2980B9" Offset="1"/>
        </LinearGradientBrush>
    </Border.Background>
    <TextBlock Text="Linear Gradient" 
               Foreground="White" 
               FontWeight="Bold"/>
</Border>
```

**LinearGradientBrush:**
- StartPoint="0,0" = มุมซ้าย-บน
- EndPoint="1,1" = มุมขวา-ล่าง
- Gradient จากซ้ายบนไปขวาล่าง

### Demo 5.3: Gradient Background - Radial

```xml
<Border BorderBrush="Red" BorderThickness="2" 
        CornerRadius="10" Padding="20" Margin="10">
    <Border.Background>
        <RadialGradientBrush>
            <GradientStop Color="#E74C3C" Offset="0"/>
            <GradientStop Color="#C0392B" Offset="1"/>
        </RadialGradientBrush>
    </Border.Background>
    <TextBlock Text="Radial Gradient" 
               Foreground="White" 
               FontWeight="Bold"/>
</Border>
```

**RadialGradientBrush:** แผ่จากตรงกลางออกด้านนอก

### Demo 5.4: Image Background

```xml
<Border BorderBrush="Gray" BorderThickness="2" 
        CornerRadius="10" Height="200" Width="300">
    <Border.Background>
        <ImageBrush ImageSource="background.jpg" Stretch="UniformToFill"/>
    </Border.Background>
    <TextBlock Text="Image Background" 
               Foreground="White" 
               FontSize="24" 
               FontWeight="Bold"
               HorizontalAlignment="Center" 
               VerticalAlignment="Center"/>
</Border>
```

---

## ส่วนที่ 6: Card Design (20:00 - 26:00)

### Demo 6.1: Simple Card

```xml
<Border BorderBrush="LightGray" 
        BorderThickness="1" 
        CornerRadius="10"
        Background="White"
        Padding="20" 
        Margin="10">
    <StackPanel>
        <TextBlock Text="Card Title" 
                   FontSize="20" 
                   FontWeight="Bold"/>
        <TextBlock Text="This is a simple card design with border." 
                   TextWrapping="Wrap" 
                   Margin="0,10"/>
        <Button Content="Action" 
                HorizontalAlignment="Left" 
                Padding="20,8"/>
    </StackPanel>
</Border>
```

### Demo 6.2: Colored Card

```xml
<Border BorderBrush="#3498DB" 
        BorderThickness="2" 
        CornerRadius="10"
        Background="#EBF5FB"
        Padding="20" 
        Margin="10">
    <StackPanel>
        <TextBlock Text="📊 Statistics" 
                   FontSize="18" 
                   FontWeight="Bold" 
                   Foreground="#3498DB"/>
        <TextBlock Text="Total Users: 1,234" 
                   Margin="0,10,0,5"/>
        <TextBlock Text="Active Today: 456"/>
    </StackPanel>
</Border>
```

### Demo 6.3: Product Card

```xml
<Border BorderBrush="LightGray" 
        BorderThickness="1" 
        CornerRadius="15"
        Background="White"
        Padding="15" 
        Margin="10"
        Width="250">
    <StackPanel>
        <Border CornerRadius="10" 
                Height="150" 
                Background="LightGray" 
                Margin="0,0,0,10">
            <TextBlock Text="🖼️ Image" 
                       HorizontalAlignment="Center" 
                       VerticalAlignment="Center" 
                       FontSize="24"/>
        </Border>
        
        <TextBlock Text="Product Name" 
                   FontSize="16" 
                   FontWeight="Bold"/>
        <TextBlock Text="$99.99" 
                   FontSize="20" 
                   Foreground="Green" 
                   Margin="0,5"/>
        <TextBlock Text="In Stock" 
                   Foreground="Gray" 
                   FontSize="12"/>
        
        <Button Content="Add to Cart" 
                Background="DodgerBlue" 
                Foreground="White" 
                Margin="0,10,0,0" 
                Padding="0,8"/>
    </StackPanel>
</Border>
```

### Demo 6.4: Nested Borders (Shadow Effect)

```xml
<Border BorderBrush="LightGray" 
        BorderThickness="0" 
        CornerRadius="10"
        Background="White"
        Margin="15">
    <Border.Effect>
        <DropShadowEffect Color="Gray" 
                          BlurRadius="10" 
                          ShadowDepth="5" 
                          Opacity="0.3"/>
    </Border.Effect>
    
    <Border BorderBrush="DodgerBlue" 
            BorderThickness="0,3,0,0" 
            CornerRadius="10"
            Padding="20">
        <StackPanel>
            <TextBlock Text="Card with Shadow" 
                       FontSize="18" 
                       FontWeight="Bold"/>
            <TextBlock Text="Using DropShadowEffect" 
                       Margin="0,10" 
                       TextWrapping="Wrap"/>
        </StackPanel>
    </Border>
</Border>
```

---

## ส่วนที่ 7: Use Cases (26:00 - 32:00)

### 7.1 Section Divider

```xml
<StackPanel>
    <Border BorderBrush="LightGray" 
            BorderThickness="1" 
            CornerRadius="5"
            Background="#F8F9FA"
            Padding="15" 
            Margin="10">
        <TextBlock Text="Section 1: Introduction" 
                   FontWeight="Bold"/>
    </Border>
    
    <Border BorderBrush="LightGray" 
            BorderThickness="1" 
            CornerRadius="5"
            Background="#F8F9FA"
            Padding="15" 
            Margin="10">
        <TextBlock Text="Section 2: Content" 
                   FontWeight="Bold"/>
    </Border>
    
    <Border BorderBrush="LightGray" 
            BorderThickness="1" 
            CornerRadius="5"
            Background="#F8F9FA"
            Padding="15" 
            Margin="10">
        <TextBlock Text="Section 3: Conclusion" 
                   FontWeight="Bold"/>
    </Border>
</StackPanel>
```

### 7.2 Alert/Notification

```xml
<StackPanel>
    <!-- Success Alert -->
    <Border BorderBrush="#28A745" 
            BorderThickness="2,0,0,0" 
            Background="#D4EDDA"
            Padding="15" 
            Margin="10">
        <StackPanel Orientation="Horizontal">
            <TextBlock Text="✓" 
                       Foreground="#28A745" 
                       FontSize="20" 
                       FontWeight="Bold" 
                       Margin="0,0,10,0"/>
            <TextBlock Text="Success! Your changes have been saved." 
                       Foreground="#155724"/>
        </StackPanel>
    </Border>
    
    <!-- Warning Alert -->
    <Border BorderBrush="#FFC107" 
            BorderThickness="2,0,0,0" 
            Background="#FFF3CD"
            Padding="15" 
            Margin="10">
        <StackPanel Orientation="Horizontal">
            <TextBlock Text="⚠" 
                       Foreground="#FFC107" 
                       FontSize="20" 
                       FontWeight="Bold" 
                       Margin="0,0,10,0"/>
            <TextBlock Text="Warning! Please check your input." 
                       Foreground="#856404"/>
        </StackPanel>
    </Border>
    
    <!-- Error Alert -->
    <Border BorderBrush="#DC3545" 
            BorderThickness="2,0,0,0" 
            Background="#F8D7DA"
            Padding="15" 
            Margin="10">
        <StackPanel Orientation="Horizontal">
            <TextBlock Text="✗" 
                       Foreground="#DC3545" 
                       FontSize="20" 
                       FontWeight="Bold" 
                       Margin="0,0,10,0"/>
            <TextBlock Text="Error! Something went wrong." 
                       Foreground="#721C24"/>
        </StackPanel>
    </Border>
</StackPanel>
```

### 7.3 Custom Button

```xml
<Border BorderBrush="DodgerBlue" 
        BorderThickness="2" 
        CornerRadius="20"
        Background="White"
        Padding="30,10" 
        Margin="10"
        Cursor="Hand">
    <Border.Style>
        <Style TargetType="Border">
            <Style.Triggers>
                <Trigger Property="IsMouseOver" Value="True">
                    <Setter Property="Background" Value="DodgerBlue"/>
                </Trigger>
            </Style.Triggers>
        </Style>
    </Border.Style>
    
    <TextBlock Text="Custom Button" 
               FontWeight="Bold" 
               HorizontalAlignment="Center"/>
</Border>
```

### 7.4 Profile Card

```xml
<Border BorderBrush="LightGray" 
        BorderThickness="1" 
        CornerRadius="10"
        Background="White"
        Padding="20" 
        Width="300">
    <StackPanel>
        <Border CornerRadius="50" 
                Width="100" 
                Height="100" 
                Background="LightGray"
                HorizontalAlignment="Center">
            <TextBlock Text="👤" 
                       FontSize="48" 
                       HorizontalAlignment="Center" 
                       VerticalAlignment="Center"/>
        </Border>
        
        <TextBlock Text="John Doe" 
                   FontSize="20" 
                   FontWeight="Bold" 
                   HorizontalAlignment="Center" 
                   Margin="0,15,0,5"/>
        
        <TextBlock Text="Software Developer" 
                   HorizontalAlignment="Center" 
                   Foreground="Gray"/>
        
        <Border BorderBrush="LightGray" 
                BorderThickness="0,1,0,0" 
                Margin="0,15,0,10">
            <Grid Margin="0,10,0,0">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="*"/>
                    <ColumnDefinition Width="*"/>
                    <ColumnDefinition Width="*"/>
                </Grid.ColumnDefinitions>
                
                <StackPanel Grid.Column="0" HorizontalAlignment="Center">
                    <TextBlock Text="120" 
                               FontSize="18" 
                               FontWeight="Bold" 
                               HorizontalAlignment="Center"/>
                    <TextBlock Text="Posts" 
                               FontSize="12" 
                               Foreground="Gray" 
                               HorizontalAlignment="Center"/>
                </StackPanel>
                
                <StackPanel Grid.Column="1" HorizontalAlignment="Center">
                    <TextBlock Text="543" 
                               FontSize="18" 
                               FontWeight="Bold" 
                               HorizontalAlignment="Center"/>
                    <TextBlock Text="Followers" 
                               FontSize="12" 
                               Foreground="Gray" 
                               HorizontalAlignment="Center"/>
                </StackPanel>
                
                <StackPanel Grid.Column="2" HorizontalAlignment="Center">
                    <TextBlock Text="234" 
                               FontSize="18" 
                               FontWeight="Bold" 
                               HorizontalAlignment="Center"/>
                    <TextBlock Text="Following" 
                               FontSize="12" 
                               Foreground="Gray" 
                               HorizontalAlignment="Center"/>
                </StackPanel>
            </Grid>
        </Border>
    </StackPanel>
</Border>
```

---

## ส่วนที่ 8: Tips & Best Practices (32:00 - 35:00)

### 8.1 ใช้ CornerRadius ให้เหมาะสม

```xml
<!-- ✅ ดี: CornerRadius พอดี -->
<Border CornerRadius="5">
    <!-- Small elements -->
</Border>

<Border CornerRadius="10">
    <!-- Medium elements -->
</Border>

<Border CornerRadius="15">
    <!-- Large elements -->
</Border>

<!-- ⚠️ ระวัง: CornerRadius มากเกินไป -->
<Border CornerRadius="100" Width="200" Height="50">
    <!-- อาจดูแปลก -->
</Border>
```

### 8.2 Padding vs Margin

```xml
<!-- Padding = ระยะห่างภายใน -->
<Border Background="LightBlue" Padding="20">
    <TextBlock Text="Content มี space รอบๆ"/>
</Border>

<!-- Margin = ระยะห่างภายนอก -->
<Border Background="LightBlue" Margin="20">
    <TextBlock Text="Border มี space รอบๆ"/>
</Border>
```

### 8.3 BorderThickness Optimization

```xml
<!-- ✅ ดี: ใช้ความหนาพอดี -->
<Border BorderThickness="1">  <!-- Subtle -->
<Border BorderThickness="2">  <!-- Normal -->
<Border BorderThickness="3">  <!-- Emphasis -->

<!-- ⚠️ ระวัง: หนาเกินไป -->
<Border BorderThickness="10">  <!-- อาจดูหนาเกินไป -->
```

### 8.4 Performance

- Border เบามาก ไม่กระทบ Performance
- ใช้ได้เยอะตามต้องการ
- ดีกว่าการใช้ Image สำหรับกรอบ

---

## ส่วนที่ 9: Wrap Up และ Outro (35:00 - 37:00)

**สรุปสิ่งที่เราได้เรียนรู้วันนี้:**

1. ✅ Border = สร้างกรอบและพื้นหลัง
2. ✅ BorderBrush, BorderThickness - สีและความหนา
3. ✅ CornerRadius - มุมมน
4. ✅ Background - Solid, Gradient, Image
5. ✅ Padding - ระยะห่างภายใน
6. ✅ Use Cases: Card, Alert, Section, Profile
7. ✅ Asymmetric BorderThickness และ CornerRadius

**Border เหมาะสำหรับ:**
- Card Design
- Alert/Notification
- Section Divider
- Custom Button
- Profile Card
- Product Card

**จุดเด่นของ Border:**
- สร้างกรอบสวยงาม
- รองรับมุมมน
- Flexible - กำหนดได้หลายแบบ
- Performance ดี

**ในตอนต่อไป:**

เราจะมาเรียนรู้เกี่ยวกับ **Viewbox** ซึ่งเป็น Control สำหรับ
ปรับขนาด Content ให้พอดีกับพื้นที่อัตโนมัติ เหมาะสำหรับ Responsive Design!

**อย่าลืม:**
- กด Like ถ้าชอบ
- Subscribe เพื่อติดตามตอนต่อไป
- Comment บอกว่าอยากเรียนเรื่องอะไรต่อไป

**ขอบคุณที่รับชมครับ แล้วพบกันใหม่ตอนหน้า สวัสดีครับ!**

---

## เอกสารอ้างอิง

### Official Documentation
- [Border Class - Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.border)
- [CornerRadius Struct - Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/api/system.windows.cornerradius)

### Properties Reference
```
BorderBrush: Brush (สีกรอบ)
BorderThickness: Thickness (ความหนา - Left,Top,Right,Bottom)
CornerRadius: CornerRadius (มุมมน - TopLeft,TopRight,BottomRight,BottomLeft)
Background: Brush (พื้นหลัง)
Padding: Thickness (ระยะห่างภายใน)
Child: UIElement (Element ภายใน - เก็บได้ 1 ตัว)
```

### Thickness Syntax
```xml
<!-- Single value: ทุกด้านเท่ากัน -->
<Border BorderThickness="2"/>

<!-- Two values: Horizontal, Vertical -->
<Border BorderThickness="2,5"/>

<!-- Four values: Left, Top, Right, Bottom -->
<Border BorderThickness="1,2,3,4"/>
```

### CornerRadius Syntax
```xml
<!-- Single value: ทุกมุมเท่ากัน -->
<Border CornerRadius="10"/>

<!-- Four values: TopLeft, TopRight, BottomRight, BottomLeft -->
<Border CornerRadius="10,0,10,0"/>
```

---

## Tips & Best Practices

1. **CornerRadius**: ใช้พอดี ไม่มากเกินไป (5-15 สำหรับ elements ปกติ)
2. **BorderThickness**: 1-2px เหมาะกับ UI ทั่วไป
3. **Padding**: ให้ Content มี breathing space
4. **Background**: ใช้ Gradient สำหรับ Modern Look

---

## Common Mistakes (ข้อผิดพลาดที่พบบ่อย)

### ❌ CornerRadius มากเกินไป
```xml
<!-- ผิด: CornerRadius มากเกินไป -->
<Border Width="100" Height="30" CornerRadius="50">
    <TextBlock Text="Too Rounded"/>
</Border>
```

### ✅ ถูกต้อง
```xml
<Border Width="100" Height="30" CornerRadius="5">
    <TextBlock Text="Just Right"/>
</Border>
```

### ❌ ลืมกำหนด Padding
```xml
<!-- ผิด: Content ติดกรอบ -->
<Border BorderBrush="Black" BorderThickness="2">
    <TextBlock Text="No Space"/>
</Border>
```

### ✅ ถูกต้อง
```xml
<Border BorderBrush="Black" BorderThickness="2" Padding="10">
    <TextBlock Text="Has Space"/>
</Border>
```

### ❌ Border ซ้อนมากเกินไป
```xml
<!-- ผิด: ซ้อนมากเกินไป -->
<Border>
    <Border>
        <Border>
            <Border>
                <TextBlock Text="Too Many Borders"/>
            </Border>
        </Border>
    </Border>
</Border>
```

### ✅ ถูกต้อง
```xml
<!-- ใช้ Border ตามความจำเป็น -->
<Border BorderBrush="Gray" BorderThickness="1" CornerRadius="5" Padding="10">
    <TextBlock Text="Single Border"/>
</Border>
```

---

## Code Examples Repository

Source code สำหรับ Episode นี้สามารถดาวน์โหลดได้ที่:
- GitHub: [WPF_Episode10_Border](https://github.com/koson/WPF_Episode10_Border)

---

**End of Script**