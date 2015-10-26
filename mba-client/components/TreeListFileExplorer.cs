﻿using DevExpress.Utils;
using DevExpress.Xpf.Grid;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mba_client.components
{
    class TreeListFileExplorer
    {
        public TreeListControl treeListControl;
        private TreeListView treeListView;
        public delegate void SelectExcelFileDelegate(object sender, String fullFileName);
        public event SelectExcelFileDelegate SelectExcelFile;
        public TreeListFileExplorer()
        {
            treeListControl = new TreeListControl { FontSize = 10, SelectionMode = MultiSelectMode.Row };

            treeListView = new TreeListView { AllowPerPixelScrolling = true, ShowTotalSummary = true, AutoWidth = true };
            treeListView.NodeExpanding += treeListView_NodeExpanding;
            treeListView.RowDoubleClick += treeListView_MouseDoubleClick;

            treeListControl.Columns.Add(new TreeListColumn { FieldName = "Name", ReadOnly = true });
            treeListControl.View = treeListView;

            Helper = new FileSystemHelper();
            InitDrives();
        }

        private void treeListView_MouseDoubleClick(object sender, RowDoubleClickEventArgs e)
        {
            var s = (FileSystemItem) ((TreeListView) sender).FocusedNode.Content;
            // TODO: сделать проверку через регулярное выражение
            if (SelectExcelFile != null && (s.FullName.IndexOf(".xls", 0, StringComparison.InvariantCultureIgnoreCase) > -1
                                            || s.FullName.IndexOf(".xlsx", 0, StringComparison.InvariantCultureIgnoreCase) > -1)
               )
            {
                SelectExcelFile(this, s.FullName);
            }
        }

        private void treeListView_NodeExpanding(object sender, DevExpress.Xpf.Grid.TreeList.TreeListNodeAllowEventArgs e)
        {
            TreeListNode node = e.Node;
            if (node.Tag == null || (bool)node.Tag == false)
            {
                InitFolder(node);
                node.Tag = true;
            }
        }

        FileSystemDataProvider Helper { get; set; }

        public void InitDrives()
        {
            try
            {
                string[] root = Helper.GetLogicalDrives();

                foreach (string s in root)
                {
                    TreeListNode node = new TreeListNode() { Content = new FileSystemItem(s, "Drive", "<Drive>", s) };
                    treeListView.Nodes.Add(node);
                    node.IsExpandButtonVisible = DefaultBoolean.True;
                }
            }
            catch { }
        }
        private void InitFolder(TreeListNode treeListNode)
        {
            InitFolders(treeListNode);
            InitFiles(treeListNode);
        }

        private void InitFiles(TreeListNode treeListNode)
        {
            FileSystemItem item = treeListNode.Content as FileSystemItem;
            if (item == null) return;
            TreeListNode node;
            try
            {
                string[] root = Helper.GetFiles(item.FullName);
                foreach (string s in root)
                {
                    node = new TreeListNode() { Content = new FileSystemItem(Helper.GetFileName(s), "File", Helper.GetFileSize(s).ToString(), s) };
                    node.IsExpandButtonVisible = DefaultBoolean.False;
                    treeListNode.Nodes.Add(node);
                }
            }
            catch { }
        }

        private void InitFolders(TreeListNode treeListNode)
        {
            FileSystemItem item = treeListNode.Content as FileSystemItem;
            if (item == null) return;

            try
            {
                string[] root = Helper.GetDirectories(item.FullName);
                foreach (string s in root)
                {
                    try
                    {
                        TreeListNode node = new TreeListNode() { Content = new FileSystemItem(Helper.GetDirectoryName(s), "Folder", "<Folder>", s) };
                        treeListNode.Nodes.Add(node);

                        node.IsExpandButtonVisible = HasFiles(s) ? DefaultBoolean.True : DefaultBoolean.False;
                    }
                    catch { }
                }
            }
            catch { }
        }

        private bool HasFiles(string path)
        {
            string[] root = Helper.GetFiles(path);
            if (root.Length > 0) return true;
            root = Helper.GetDirectories(path);
            if (root.Length > 0) return true;
            return false;
        }

        public abstract class FileSystemDataProvider
        {
            public abstract string[] GetLogicalDrives();
            public abstract string[] GetDirectories(string path);
            public abstract string[] GetFiles(string path);
            public abstract string GetDirectoryName(string path);
            public abstract string GetFileName(string path);
            public abstract long GetFileSize(string path);
        }

        public class FileSystemHelper : FileSystemDataProvider
        {
            public override string[] GetLogicalDrives()
            {
                return Directory.GetLogicalDrives();
            }
            public override string[] GetDirectories(string path)
            {
                return Directory.GetDirectories(path);
            }
            public override string[] GetFiles(string path)
            {
                return Directory.GetFiles(path);
            }
            public override string GetDirectoryName(string path)
            {
                return new DirectoryInfo(path).Name;
            }
            public override string GetFileName(string path)
            {
                return new FileInfo(path).Name;
            }
            public override long GetFileSize(string path)
            {
                return new FileInfo(path).Length;
            }
        }

        public class FileSystemItem
        {
            public FileSystemItem(string name, string type, string size, string fullName)
            {
                Name = name;
                ItemType = type;
                Size = size;
                FullName = fullName;
            }
            public string Name { get; set; }
            public string ItemType { get; set; }
            public string Size { get; set; }
            public string FullName { get; set; }
        }
    }
}
