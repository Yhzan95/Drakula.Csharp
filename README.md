# <p align="center">DrakulaCsharp</p>
Drakula is Draculatheme.Com based theme for Csharp winform application. You can customise the color palette on **Drakula.cs** and add more controls if needed (you can contribute to this project),
I'll update this when i have free time. Builded with Visual Studio 2022 (Net Framework 4.7.2).
<p align="center">
  <img src="https://github.com/Yhzan95/Drakula.Csharp/blob/main/Main.png?raw=true" alt="Drakula C# Screenshot">
</p>

## Features    
- DatagridView
- Tab Control
- Label
- Link Label
- Button
- ComboBox
- TextBox
- ListBox
- ListView
- CheckedBox
- RadioButton
- Panel
- GroupBox
- TrackBar

| ColorName | ColorCode |
| -------- | -------- |
| Background    | #282A36    |
| Current Line    | #44475A    |
| Foreground    | #F8F8F2    |        
| Comment    | #6272A4    |    
| Cyan    | #8BE9FD    |    
| Green    | #50FA7B    |
| Orange    | #FFB86C    |    
| Pink    | #FF79C6    |    
| Purple    | #FF79C6    |    
| Red    | #FF5555    |    
| Yellow    | #F1FA8C    |

## Usage
Just drag and drop **Drakula.cs** in your project and call it to your mainform.
```js
namespace DrakulaCsharp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DrakulaTheme.ApplyDrakula(this); // Apply Drakula theme to controls
            DrakulaTheme.ApplyDrakulaDataGridView(dataGridView1); // Apply Drakula datagrid (If you wanna use it)
        }
    }
}
```

