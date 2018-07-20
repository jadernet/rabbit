﻿using System;
using System.Collections;
using System.IO;

namespace lazebird.rabbit.fs
{
    public class rfs
    {
        Action<string> log;
        public rfs(Action<string> log)
        {
            this.log = log;
        }
        public int addfile(Hashtable hs, string vpath, string rpath)  // vpath: virtual path, rpath: real path
        {
            FileInfo f = new FileInfo(rpath);
            if (!f.Exists || f.Attributes.HasFlag(FileAttributes.System))
            {
                log("!F: " + f.FullName + ", A: " + f.Attributes.ToString());
                return 0;
            }
            vpath = vpath + f.Name;
            if (hs.ContainsKey(vpath))
            {
                log("!F: " + f.FullName + " exists");
                return 0;
            }
            hs.Add(vpath, new rfile("file", f.FullName, f.Length, f.LastWriteTime));
            log("+F: " + vpath);
            return 1;
        }
        public int delfile(Hashtable hs, string vpath, string rpath)  // vpath: virtual path, rpath: real path
        {
            FileInfo f = new FileInfo(rpath);
            if (!f.Exists || f.Attributes.HasFlag(FileAttributes.System))
            {
                log("!F: " + f.FullName + ", A: " + f.Attributes.ToString());
                return 0;
            }
            vpath = vpath + f.Name;
            hs.Remove(vpath);
            log("-F: " + vpath);
            return 1;
        }
        public int adddir(Hashtable hs, string vpath, string rpath, bool recursive) // vpath: virtual path, rpath: real path
        {
            DirectoryInfo dir = new DirectoryInfo(rpath);
            if (!dir.Exists || dir.Attributes.HasFlag(FileAttributes.System)) // fix crash bug for select a dir E:
            {
                log("!D: " + dir.FullName + ", A: " + dir.Attributes.ToString());
                return 0;
            }
            vpath = vpath + dir.Name + "/";
            if (hs.ContainsKey(vpath))
            {
                log("!D: " + dir.FullName + " exists");
                return 0;
            }
            hs.Add(vpath, new rfile("dir", dir.FullName, 0, dir.LastWriteTime));
            log("+D: " + vpath);
            int count = 1;
            foreach (FileInfo f in dir.GetFiles())
                count += addfile(hs, vpath, f.FullName);
            if (recursive)
                foreach (DirectoryInfo d in dir.GetDirectories())
                    count += adddir(hs, vpath, d.FullName, recursive);
            return count;
        }
        public int deldir(Hashtable hs, string vpath, string rpath) // vpath: virtual path, rpath: real path
        {
            DirectoryInfo dir = new DirectoryInfo(rpath);
            if (!dir.Exists || dir.Attributes.HasFlag(FileAttributes.System)) // fix crash bug for select a dir E:
            {
                log("!D: " + dir.FullName + ", A: " + dir.Attributes.ToString());
                return 0;
            }
            vpath = vpath + dir.Name + "/";
            ArrayList list = new ArrayList();
            foreach (string f in hs.Keys)
            {
                if (f.Length >= vpath.Length && f.Substring(0, vpath.Length) == vpath)
                {
                    list.Add(f);
                }
            }
            int count = list.Count;
            foreach (string f in list)
            {
                log("-" + ((((rfile)hs[f]).type == "dir") ? "D" : "F") + ": " + f);
                hs.Remove(f);
            }
            return count;
        }
        public int readfile(string path)
        {
            return 1;
        }
        public int writefile(string path)
        {
            return 1;
        }
    }
}
