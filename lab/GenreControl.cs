using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Windows.Forms;

namespace lab {
public partial class GenreControl : UserControl {
    public string Value {
        get => GenreUtils.ConvertToString(_genre);
        set {
            _genre = GenreUtils.Parse(value);
            ValueChanged?.Invoke(_genre);
        }
    }

    // ReSharper disable once MemberCanBePrivate.Global
    public Image RapImage { get; set; }

    // ReSharper disable once MemberCanBePrivate.Global
    public Image PopImage { get; set; }

    // ReSharper disable once MemberCanBePrivate.Global
    public Image RockImage { get; set; }

    public event Action<Genre> ValueChanged;

    private Genre _genre;

    public GenreControl() {
        InitializeComponent();
        _genre = Genre.Rap;
    }

    private void NextValue() {
        _genre = GenreUtils.NextGenre(_genre);
        pictureBox.Image = ConvertToImage(_genre);
        label.Text = GenreUtils.ConvertToString(_genre);
    }

    private Image ConvertToImage(Genre genre) {
        return genre switch {
            Genre.Pop => PopImage,
            Genre.Rap => RapImage,
            Genre.Rock => RockImage,
            _ => throw new ArgumentOutOfRangeException(nameof(genre), genre, null)
        };
    }

    private void pictureBox_Click(object sender, EventArgs e) {
        NextValue();
    }

    private void GenreControl_Load(object sender, EventArgs e) {
        NextValue();
    }
}

public enum Genre {
    Rock,
    Rap,
    Pop
}

[SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
public static class GenreUtils {
    public const string Rock = "rock";
    public const string Rap = "rap";
    public const string Pop = "pop";

    public static Genre Parse(string name) {
        return name switch {
            Rock => Genre.Rock,
            Rap => Genre.Rap,
            _ => Genre.Pop
        };
    }


    public static string ConvertToString(Genre genre) {
        return genre switch {
            Genre.Pop => Pop,
            Genre.Rap => Rap,
            Genre.Rock => Rock,
            _ => throw new ArgumentOutOfRangeException(nameof(genre), genre, null)
        };
    }

    public static Genre NextGenre(Genre current) {
        return current switch {
            Genre.Pop => Genre.Rap,
            Genre.Rap => Genre.Rock,
            Genre.Rock => Genre.Pop,
            _ => throw new ArgumentOutOfRangeException(nameof(current), current, null)
        };
    }
}
}