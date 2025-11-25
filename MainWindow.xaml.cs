using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPF_Episode10_Border
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowBasicBorder(object sender, RoutedEventArgs e)
        {
            var mainStack = CreateMainStack("Demo 1: Basic Border");

            AddDescription(mainStack, "Border with different BorderBrush and BorderThickness values:");

            var grid = new UniformGrid { Columns = 3, Margin = new Thickness(0, 20, 0, 0) };

            // Simple border
            var border1 = CreateDemoCard("Simple Border", "BorderBrush=Black\nBorderThickness=2");
            border1.BorderBrush = Brushes.Black;
            border1.BorderThickness = new Thickness(2);
            grid.Children.Add(border1);

            // With background
            var border2 = CreateDemoCard("With Background", "Background=LightBlue\nBorderBrush=Blue\nBorderThickness=2");
            border2.Background = Brushes.LightBlue;
            border2.BorderBrush = Brushes.Blue;
            border2.BorderThickness = new Thickness(2);
            grid.Children.Add(border2);

            // With padding
            var border3 = CreateDemoCard("With Padding", "Padding=20\nBackground=LightGreen\nBorderBrush=Green");
            border3.Padding = new Thickness(20);
            border3.Background = Brushes.LightGreen;
            border3.BorderBrush = Brushes.Green;
            border3.BorderThickness = new Thickness(2);
            grid.Children.Add(border3);

            mainStack.Children.Add(grid);
            UpdateContent(mainStack);
        }

        private void ShowBorderThickness(object sender, RoutedEventArgs e)
        {
            var mainStack = CreateMainStack("Demo 2: BorderThickness Variations");

            AddDescription(mainStack, "Different ways to specify BorderThickness:");

            var grid = new UniformGrid { Rows = 2, Columns = 2, Margin = new Thickness(0, 20, 0, 0) };

            // Thin (1px)
            var border1 = CreateDemoCard("Thin Border", "BorderThickness=1");
            border1.BorderBrush = Brushes.Gray;
            border1.BorderThickness = new Thickness(1);
            grid.Children.Add(border1);

            // Thick (5px)
            var border2 = CreateDemoCard("Thick Border", "BorderThickness=5");
            border2.BorderBrush = Brushes.Gray;
            border2.BorderThickness = new Thickness(5);
            grid.Children.Add(border2);

            // Bottom only
            var border3 = CreateDemoCard("Bottom Border", "BorderThickness=0,0,0,3\n(Underline effect)");
            border3.BorderBrush = Brushes.Blue;
            border3.BorderThickness = new Thickness(0, 0, 0, 3);
            grid.Children.Add(border3);

            // Left accent
            var border4 = CreateDemoCard("Left Accent", "BorderThickness=5,0,0,0\n(Accent bar)");
            border4.BorderBrush = Brushes.Red;
            border4.BorderThickness = new Thickness(5, 0, 0, 0);
            border4.Background = Brushes.LightGray;
            grid.Children.Add(border4);

            mainStack.Children.Add(grid);
            UpdateContent(mainStack);
        }

        private void ShowCornerRadius(object sender, RoutedEventArgs e)
        {
            var mainStack = CreateMainStack("Demo 3: CornerRadius for Rounded Corners");

            AddDescription(mainStack, "CornerRadius makes borders modern and friendly:");

            var grid = new UniformGrid { Rows = 2, Columns = 3, Margin = new Thickness(0, 20, 0, 0) };

            // No rounding
            var border1 = CreateDemoCard("Sharp", "CornerRadius=0");
            border1.Background = Brushes.LightBlue;
            border1.CornerRadius = new CornerRadius(0);
            grid.Children.Add(border1);

            // Subtle rounding
            var border2 = CreateDemoCard("Subtle", "CornerRadius=5");
            border2.Background = Brushes.LightBlue;
            border2.CornerRadius = new CornerRadius(5);
            grid.Children.Add(border2);

            // Moderate rounding
            var border3 = CreateDemoCard("Moderate", "CornerRadius=10");
            border3.Background = Brushes.LightBlue;
            border3.CornerRadius = new CornerRadius(10);
            grid.Children.Add(border3);

            // Prominent rounding
            var border4 = CreateDemoCard("Prominent", "CornerRadius=20");
            border4.Background = Brushes.LightBlue;
            border4.CornerRadius = new CornerRadius(20);
            grid.Children.Add(border4);

            // Top rounded only
            var border5 = CreateDemoCard("Top Only", "CornerRadius=15,15,0,0");
            border5.Background = Brushes.LightGreen;
            border5.CornerRadius = new CornerRadius(15, 15, 0, 0);
            grid.Children.Add(border5);

            // Circle (pill)
            var border6 = new Border
            {
                Width = 100,
                Height = 100,
                Background = Brushes.Orange,
                CornerRadius = new CornerRadius(50),
                Margin = new Thickness(10),
                Child = new TextBlock
                {
                    Text = "Circle\nCornerRadius=50",
                    TextAlignment = TextAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center,
                    Foreground = Brushes.White,
                    FontWeight = FontWeights.Bold
                }
            };
            grid.Children.Add(border6);

            mainStack.Children.Add(grid);
            UpdateContent(mainStack);
        }

        private void ShowBackgrounds(object sender, RoutedEventArgs e)
        {
            var mainStack = CreateMainStack("Demo 4: Background Colors");

            AddDescription(mainStack, "Border supports various background types:");

            var grid = new UniformGrid { Rows = 2, Columns = 3, Margin = new Thickness(0, 20, 0, 0) };

            // Solid colors
            var colors = new[] { "White", "LightBlue", "LightGreen", "LightCoral", "LightGoldenrodYellow", "#FFE0F0FF" };
            var labels = new[] { "White", "LightBlue", "LightGreen", "LightCoral", "LightGoldenrod\nYellow", "Hex Color\n#FFE0F0FF" };

            for (int i = 0; i < colors.Length; i++)
            {
                var border = CreateDemoCard(labels[i], $"Background={colors[i]}");
                border.Background = (Brush)new BrushConverter().ConvertFrom(colors[i]);
                border.BorderBrush = Brushes.Gray;
                border.BorderThickness = new Thickness(1);
                grid.Children.Add(border);
            }

            mainStack.Children.Add(grid);
            UpdateContent(mainStack);
        }

        private void ShowCards(object sender, RoutedEventArgs e)
        {
            var mainStack = CreateMainStack("Demo 5: Modern Card Designs");

            AddDescription(mainStack, "Cards are one of the most common uses for Border:");

            var grid = new UniformGrid { Columns = 2, Margin = new Thickness(0, 20, 0, 0) };

            // Simple card
            var card1 = new Border
            {
                Background = Brushes.White,
                BorderBrush = Brushes.LightGray,
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(10),
                Padding = new Thickness(20),
                Margin = new Thickness(10)
            };
            var card1Stack = new StackPanel();
            card1Stack.Children.Add(new TextBlock { Text = "Simple Card", FontSize = 18, FontWeight = FontWeights.Bold, Margin = new Thickness(0, 0, 0, 10) });
            card1Stack.Children.Add(new TextBlock { Text = "Clean white background with subtle gray border and rounded corners.", TextWrapping = TextWrapping.Wrap });
            card1.Child = card1Stack;
            grid.Children.Add(card1);

            // Dashboard widget
            var card2 = new Border
            {
                Background = Brushes.LightBlue,
                BorderBrush = Brushes.Blue,
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(10),
                Padding = new Thickness(20),
                Margin = new Thickness(10)
            };
            var card2Stack = new StackPanel();
            card2Stack.Children.Add(new TextBlock { Text = "Dashboard Widget", FontSize = 16, FontWeight = FontWeights.Bold, Margin = new Thickness(0, 0, 0, 10) });
            card2Stack.Children.Add(new TextBlock { Text = "$12,345", FontSize = 32, FontWeight = FontWeights.Bold, Margin = new Thickness(0, 0, 0, 10) });
            card2Stack.Children.Add(new TextBlock { Text = "+12% from last month", Foreground = Brushes.Green });
            card2.Child = card2Stack;
            grid.Children.Add(card2);

            // Product card
            var card3 = new Border
            {
                Background = Brushes.White,
                BorderBrush = Brushes.LightGray,
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(10),
                Padding = new Thickness(15),
                Margin = new Thickness(10)
            };
            var card3Stack = new StackPanel();
            var imageBox = new Border
            {
                Background = Brushes.LightGray,
                Height = 150,
                CornerRadius = new CornerRadius(8),
                Margin = new Thickness(0, 0, 0, 15),
                Child = new TextBlock { Text = "[Product Image]", HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center }
            };
            card3Stack.Children.Add(imageBox);
            card3Stack.Children.Add(new TextBlock { Text = "Product Name", FontSize = 16, FontWeight = FontWeights.Bold, Margin = new Thickness(0, 0, 0, 5) });
            card3Stack.Children.Add(new TextBlock { Text = "$299.99", FontSize = 20, Foreground = Brushes.Green, FontWeight = FontWeights.Bold });
            card3.Child = card3Stack;
            grid.Children.Add(card3);

            // Profile card
            var card4 = new Border
            {
                Background = Brushes.White,
                BorderBrush = Brushes.LightGray,
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(10),
                Padding = new Thickness(20),
                Margin = new Thickness(10)
            };
            var card4Stack = new StackPanel { HorizontalAlignment = HorizontalAlignment.Center };
            var avatar = new Border
            {
                Width = 80,
                Height = 80,
                CornerRadius = new CornerRadius(40),
                Background = Brushes.LightBlue,
                Margin = new Thickness(0, 0, 0, 15),
                Child = new TextBlock { Text = "JD", FontSize = 28, FontWeight = FontWeights.Bold, Foreground = Brushes.White, HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center }
            };
            card4Stack.Children.Add(avatar);
            card4Stack.Children.Add(new TextBlock { Text = "John Doe", FontSize = 18, FontWeight = FontWeights.Bold, TextAlignment = TextAlignment.Center });
            card4Stack.Children.Add(new TextBlock { Text = "Software Engineer", Foreground = Brushes.Gray, TextAlignment = TextAlignment.Center });
            card4.Child = card4Stack;
            grid.Children.Add(card4);

            mainStack.Children.Add(grid);
            UpdateContent(mainStack);
        }

        private void ShowAlerts(object sender, RoutedEventArgs e)
        {
            var mainStack = CreateMainStack("Demo 6: Alert/Notification Messages");

            AddDescription(mainStack, "Border is perfect for creating styled alert messages:");

            var stack = new StackPanel { Margin = new Thickness(0, 20, 0, 0) };

            // Success
            var success = CreateAlert("✓", "Success! Your changes have been saved.", "#D4EDDA", "#C3E6CB", "#155724");
            stack.Children.Add(success);

            // Info
            var info = CreateAlert("ℹ", "Info: You have 5 new messages.", "#D1ECF1", "#BEE5EB", "#0C5460");
            stack.Children.Add(info);

            // Warning
            var warning = CreateAlert("⚠", "Warning: Your subscription expires in 3 days.", "#FFF3CD", "#FFEAA7", "#856404");
            stack.Children.Add(warning);

            // Error
            var error = CreateAlert("✗", "Error: Failed to connect to server.", "#F8D7DA", "#F5C6CB", "#721C24");
            stack.Children.Add(error);

            mainStack.Children.Add(stack);
            UpdateContent(mainStack);
        }

        private void ShowGradients(object sender, RoutedEventArgs e)
        {
            var mainStack = CreateMainStack("Demo 7: Gradient Backgrounds");

            AddDescription(mainStack, "Border supports gradient backgrounds for modern effects:");

            var grid = new UniformGrid { Rows = 2, Columns = 2, Margin = new Thickness(0, 20, 0, 0) };

            // Horizontal gradient
            var border1 = new Border
            {
                CornerRadius = new CornerRadius(10),
                Padding = new Thickness(20),
                Margin = new Thickness(10),
                Child = new TextBlock { Text = "Horizontal Gradient", Foreground = Brushes.White, FontWeight = FontWeights.Bold, TextAlignment = TextAlignment.Center }
            };
            var gradient1 = new LinearGradientBrush { StartPoint = new Point(0, 0), EndPoint = new Point(1, 0) };
            gradient1.GradientStops.Add(new GradientStop(Colors.LightBlue, 0));
            gradient1.GradientStops.Add(new GradientStop(Colors.Blue, 1));
            border1.Background = gradient1;
            grid.Children.Add(border1);

            // Vertical gradient
            var border2 = new Border
            {
                CornerRadius = new CornerRadius(10),
                Padding = new Thickness(20),
                Margin = new Thickness(10),
                Child = new TextBlock { Text = "Vertical Gradient", FontWeight = FontWeights.Bold, TextAlignment = TextAlignment.Center }
            };
            var gradient2 = new LinearGradientBrush { StartPoint = new Point(0, 0), EndPoint = new Point(0, 1) };
            gradient2.GradientStops.Add(new GradientStop(Colors.White, 0));
            gradient2.GradientStops.Add(new GradientStop(Colors.LightGray, 1));
            border2.Background = gradient2;
            grid.Children.Add(border2);

            // Diagonal gradient
            var border3 = new Border
            {
                CornerRadius = new CornerRadius(10),
                Padding = new Thickness(20),
                Margin = new Thickness(10),
                Child = new TextBlock { Text = "Diagonal Gradient", Foreground = Brushes.White, FontWeight = FontWeights.Bold, TextAlignment = TextAlignment.Center }
            };
            var gradient3 = new LinearGradientBrush { StartPoint = new Point(0, 0), EndPoint = new Point(1, 1) };
            gradient3.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#FF6B6B"), 0));
            gradient3.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#4ECDC4"), 1));
            border3.Background = gradient3;
            grid.Children.Add(border3);

            // Radial gradient
            var border4 = new Border
            {
                CornerRadius = new CornerRadius(10),
                Padding = new Thickness(20),
                Margin = new Thickness(10),
                Child = new TextBlock { Text = "Radial Gradient", FontWeight = FontWeights.Bold, TextAlignment = TextAlignment.Center }
            };
            var gradient4 = new RadialGradientBrush();
            gradient4.GradientStops.Add(new GradientStop(Colors.Yellow, 0));
            gradient4.GradientStops.Add(new GradientStop(Colors.Orange, 0.5));
            gradient4.GradientStops.Add(new GradientStop(Colors.Red, 1));
            border4.Background = gradient4;
            grid.Children.Add(border4);

            mainStack.Children.Add(grid);
            UpdateContent(mainStack);
        }

        private void ShowPaddingMargin(object sender, RoutedEventArgs e)
        {
            var mainStack = CreateMainStack("Demo 8: Padding vs Margin");

            AddDescription(mainStack, "Understanding the difference between Padding and Margin:");

            var grid = new Grid { Margin = new Thickness(0, 20, 0, 0) };
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());

            // No Padding
            var leftStack = new StackPanel { Margin = new Thickness(10) };
            leftStack.Children.Add(new TextBlock { Text = "Without Padding:", FontWeight = FontWeights.Bold, Margin = new Thickness(0, 0, 0, 10) });
            var noPadding = new Border
            {
                Background = Brushes.LightBlue,
                BorderBrush = Brushes.Blue,
                BorderThickness = new Thickness(2),
                Child = new TextBlock { Text = "Content touches border\n(no breathing room)", TextWrapping = TextWrapping.Wrap }
            };
            leftStack.Children.Add(noPadding);

            leftStack.Children.Add(new TextBlock { Text = "\nWith Padding:", FontWeight = FontWeights.Bold, Margin = new Thickness(0, 20, 0, 10) });
            var withPadding = new Border
            {
                Background = Brushes.LightBlue,
                BorderBrush = Brushes.Blue,
                BorderThickness = new Thickness(2),
                Padding = new Thickness(20),
                Child = new TextBlock { Text = "Content has space\n(comfortable)", TextWrapping = TextWrapping.Wrap }
            };
            leftStack.Children.Add(withPadding);
            Grid.SetColumn(leftStack, 0);
            grid.Children.Add(leftStack);

            // Margin demo
            var rightStack = new StackPanel { Margin = new Thickness(10) };
            rightStack.Children.Add(new TextBlock { Text = "Without Margin:", FontWeight = FontWeights.Bold, Margin = new Thickness(0, 0, 0, 10) });
            var innerStack1 = new StackPanel();
            innerStack1.Children.Add(new Border { Background = Brushes.LightGreen, Padding = new Thickness(10), Child = new TextBlock { Text = "Border 1" } });
            innerStack1.Children.Add(new Border { Background = Brushes.LightCoral, Padding = new Thickness(10), Child = new TextBlock { Text = "Border 2 (touching)" } });
            rightStack.Children.Add(innerStack1);

            rightStack.Children.Add(new TextBlock { Text = "\nWith Margin:", FontWeight = FontWeights.Bold, Margin = new Thickness(0, 20, 0, 10) });
            var innerStack2 = new StackPanel();
            innerStack2.Children.Add(new Border { Background = Brushes.LightGreen, Padding = new Thickness(10), Margin = new Thickness(0, 0, 0, 10), Child = new TextBlock { Text = "Border 1" } });
            innerStack2.Children.Add(new Border { Background = Brushes.LightCoral, Padding = new Thickness(10), Margin = new Thickness(0, 0, 0, 10), Child = new TextBlock { Text = "Border 2 (spaced)" } });
            rightStack.Children.Add(innerStack2);
            Grid.SetColumn(rightStack, 1);
            grid.Children.Add(rightStack);

            mainStack.Children.Add(grid);
            UpdateContent(mainStack);
        }

        private void ShowAdvanced(object sender, RoutedEventArgs e)
        {
            var mainStack = CreateMainStack("Demo 9: Advanced Techniques");

            AddDescription(mainStack, "Advanced Border usage patterns:");

            var grid = new UniformGrid { Rows = 2, Columns = 2, Margin = new Thickness(0, 20, 0, 0) };

            // Nested borders (shadow effect)
            var outerBorder = new Border
            {
                Background = Brushes.Gray,
                CornerRadius = new CornerRadius(10),
                Margin = new Thickness(13, 13, 10, 10)
            };
            var innerBorder = new Border
            {
                Background = Brushes.White,
                CornerRadius = new CornerRadius(10),
                Padding = new Thickness(20),
                Margin = new Thickness(-3, -3, 0, 0),
                Child = new TextBlock { Text = "Nested Borders\n(Shadow Effect)", TextAlignment = TextAlignment.Center, FontWeight = FontWeights.Bold }
            };
            outerBorder.Child = innerBorder;
            grid.Children.Add(outerBorder);

            // Custom button
            var button = new Border
            {
                Background = Brushes.Green,
                CornerRadius = new CornerRadius(8),
                Padding = new Thickness(20, 10, 20, 10),
                Margin = new Thickness(10),
                Cursor = System.Windows.Input.Cursors.Hand,
                Child = new TextBlock { Text = "Custom Button\n(Border as Button)", Foreground = Brushes.White, FontWeight = FontWeights.Bold, TextAlignment = TextAlignment.Center }
            };
            grid.Children.Add(button);

            // Circular avatar
            var avatar = new Border
            {
                Width = 120,
                Height = 120,
                CornerRadius = new CornerRadius(60),
                Background = Brushes.Blue,
                Margin = new Thickness(10),
                Child = new TextBlock { Text = "JD", FontSize = 36, FontWeight = FontWeights.Bold, Foreground = Brushes.White, HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center }
            };
            var avatarContainer = new Border { Margin = new Thickness(10), HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center };
            var avatarStack = new StackPanel { HorizontalAlignment = HorizontalAlignment.Center };
            avatarStack.Children.Add(avatar);
            avatarStack.Children.Add(new TextBlock { Text = "Circular Avatar", TextAlignment = TextAlignment.Center, FontWeight = FontWeights.Bold, Margin = new Thickness(0, 10, 0, 0) });
            avatarContainer.Child = avatarStack;
            grid.Children.Add(avatarContainer);

            // Pill shape
            var pill = new Border
            {
                Background = Brushes.Orange,
                CornerRadius = new CornerRadius(20),
                Padding = new Thickness(25, 10, 25, 10),
                Margin = new Thickness(10),
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Child = new TextBlock { Text = "Pill Shape\n(High CornerRadius)", Foreground = Brushes.White, FontWeight = FontWeights.Bold, TextAlignment = TextAlignment.Center }
            };
            grid.Children.Add(pill);

            mainStack.Children.Add(grid);
            UpdateContent(mainStack);
        }

        // Helper methods
        private StackPanel CreateMainStack(string title)
        {
            var stack = new StackPanel();
            stack.Children.Add(new TextBlock
            {
                Text = title,
                FontSize = 24,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(0, 0, 0, 10)
            });
            return stack;
        }

        private void AddDescription(StackPanel parent, string text)
        {
            parent.Children.Add(new TextBlock
            {
                Text = text,
                FontSize = 14,
                TextWrapping = TextWrapping.Wrap,
                Margin = new Thickness(0, 0, 0, 10)
            });
        }

        private Border CreateDemoCard(string title, string description)
        {
            var border = new Border
            {
                BorderBrush = Brushes.Gray,
                BorderThickness = new Thickness(1),
                Padding = new Thickness(15),
                Margin = new Thickness(10),
                CornerRadius = new CornerRadius(5),
                MinHeight = 120
            };

            var stack = new StackPanel();
            stack.Children.Add(new TextBlock
            {
                Text = title,
                FontWeight = FontWeights.Bold,
                FontSize = 14,
                Margin = new Thickness(0, 0, 0, 10)
            });
            stack.Children.Add(new TextBlock
            {
                Text = description,
                FontSize = 11,
                Foreground = Brushes.Gray,
                TextWrapping = TextWrapping.Wrap
            });

            border.Child = stack;
            return border;
        }

        private Border CreateAlert(string icon, string message, string bgColor, string borderColor, string textColor)
        {
            var border = new Border
            {
                Background = (Brush)new BrushConverter().ConvertFrom(bgColor),
                BorderBrush = (Brush)new BrushConverter().ConvertFrom(borderColor),
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(5),
                Padding = new Thickness(15),
                Margin = new Thickness(0, 0, 0, 15)
            };

            var stack = new StackPanel { Orientation = Orientation.Horizontal };
            stack.Children.Add(new TextBlock
            {
                Text = icon,
                Foreground = (Brush)new BrushConverter().ConvertFrom(textColor),
                FontSize = 18,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(0, 0, 10, 0),
                VerticalAlignment = VerticalAlignment.Center
            });
            stack.Children.Add(new TextBlock
            {
                Text = message,
                Foreground = (Brush)new BrushConverter().ConvertFrom(textColor),
                VerticalAlignment = VerticalAlignment.Center,
                TextWrapping = TextWrapping.Wrap
            });

            border.Child = stack;
            return border;
        }

        private void UpdateContent(StackPanel content)
        {
            var container = new Border
            {
                Background = Brushes.White,
                Margin = new Thickness(20),
                Padding = new Thickness(30),
                CornerRadius = new CornerRadius(10)
            };
            container.Child = content;
            ContentPanel.Content = container;
        }
    }
}
