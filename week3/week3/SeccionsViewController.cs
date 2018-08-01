using Foundation;
using System;
using UIKit;

namespace week3
{
    public partial class SeccionsViewController : UITableViewController
    {
        public SeccionsViewController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            {
                base.ViewDidLoad();
                string[] tableItems = new string[] { "item1", "item2", "item3", "item4", "item5" };
                TableView.Source = new TableViewSource(tableItems);
            }
        }
    }
    public class TableViewSource : UITableViewSource
    {
        string[] listItem;
        public TableViewSource(string[] items)
        {
            listItem = items;
        }
        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return listItem.Length;
        }
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell("cell");
            cell.TextLabel.Text = listItem[indexPath.Row];
            return cell;
        }
    }

}