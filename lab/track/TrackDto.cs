using System;
using System.Windows.Forms;

namespace lab.track {
public class TrackDto {
    public string Name { get; set; }
    public string Author { get; set; } = "";
    public string Category { get; set; } = "";
    public DateTime CreatedAt { get; set; }

    public ListViewItem ToListViewItem(int index) {
        var item = new ListViewItem(index.ToString()) {Tag = this};
        item.SubItems.Add(Name);
        item.SubItems.Add(Author);
        item.SubItems.Add(Category);
        item.SubItems.Add(CreatedAt.ToShortDateString());
        return item;
    }

    public DialogState ToDialogState() {
        return new DialogState {
            Name = Name,
            Author = Author,
            Category = Category,
            CreatedAt = CreatedAt
        };
    }

    public Track ToModel() {
        return new Track {
            Name = Name,
            Author = Author,
            Category = Category,
            CreatedAt = CreatedAt
        };
    }
}
}