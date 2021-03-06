﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanoramicDownload.Core
{
    /// <summary>
    /// 平台识别基础类
    /// </summary>
    public  class PlatformBase
    {
        public StringBuilder urlHead = new StringBuilder(200);
        public StringBuilder urlTail = new StringBuilder(200);
        public int maximgQuality;
        public int maximgChild;
        public List<string> urlTailLis = new List<string>();
        public List<string> urlKeysList = new List<string>();

        /// <summary>
        /// 写入下载数据的抽象方法
        /// </summary>
        /// <param name="type">图片的方向</param>
        /// <param name="maxIndex">最大的下标</param>
        /// <param name="newUrl">前置的通用链接</param>
        /// <param name="maxtpye">最大图片质量下标</param>
        /// <param name="sw5">写入的流文件</param>
        public virtual void WriteDownLoad(DirectionType type= DirectionType.b, int maxIndex = 1, StringBuilder newUrl= null, int maxQuality =1, StreamWriter SWFile =null)
        {

        }

        /// <summary>
        /// 图片合成
        /// </summary>
        /// <param name="imagePath"></param>
        /// <param name="imageQuality"></param>
        /// <param name="tpye"></param>
        /// <param name="imageIndex"></param>
        /// <param name="SWFile"></param>
        public virtual void MatchingImage(string imagePath, string imageQuality, string tpye, int imageIndex, StreamWriter SWFile, int progindex)
        {

        }

        public MemoryStream ByteToStream(byte[] mybyte)
        {
            MemoryStream mymemorystream = new MemoryStream(mybyte, 0, mybyte.Length);
            return mymemorystream;
        }
        public byte[] SetImageToByteArray(string fileName)
        {
            byte[] image = null;
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                FileInfo fileInfo = new FileInfo(fileName);
                int streamLength = (int)fs.Length;
                image = new byte[streamLength];
                fs.Read(image, 0, streamLength);
                fs.Close();
                return image;
            }
            catch
            {
                return image;
            }
        }
    }
}
