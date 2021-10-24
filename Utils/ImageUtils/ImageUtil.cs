using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Utils.ImageUtils
{
    public static class ImageUtil
    {
        public static Image loadImageFromURL(string url)
        {
            int buffSize = 65536; // 一度に読み込むサイズ
            MemoryStream imgStream = new MemoryStream();

            //------------------------
            // パラメータチェック
            //------------------------
            if (url == null || url.Trim().Length <= 0)
            {
                return null;
            }

            //----------------------------
            // Webサーバに要求を投げる
            //----------------------------
            WebRequest req = WebRequest.Create(url);
            BinaryReader reader = new BinaryReader(req.GetResponse().GetResponseStream());

            //--------------------------------------------------------
            // Webサーバからの応答データを取得し、imgStreamに保存する
            //--------------------------------------------------------
            while (true)
            {
                byte[] buff = new byte[buffSize];

                // 応答データの取得
                int readBytes = reader.Read(buff, 0, buffSize);
                if (readBytes <= 0)
                {
                    // 最後まで取得した->ループを抜ける
                    break;
                }

                // バッファに追加
                imgStream.Write(buff, 0, readBytes);
            }

            return new Bitmap(imgStream);
        }
    }
}
