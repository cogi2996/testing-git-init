namespace Programming_CSharp
{
    using System;
    // tạo lớp ListBox
    public class ListBoxTest
    {
        // khởi tạo ListBox với một chuỗi
        public ListBoxTest(params string[] initialStrings)
        {
            // cấp phát không gian cho chuỗi
            strings = new String[256];
            // copy chuỗi truyền từ tham số
            foreach (string s in initialStrings)
            {
                strings[ctr++] = s;
            }
        }
        // thêm một chuỗi
        public void Add(string theString)
        {
            if (ctr >= strings.Length)
            {
                // xử lý khi chỉ mục sai
            }
            else
                strings[ctr++] = theString;
        }
        // thực hiện bộ truy cập
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= strings.Length)
                {
                    // xử lý chỉ mục sai
                }
                return strings[index];
            }
            set
            {

                if (index >= strings.Length)
                {
                    // chỉ mục vượt quá số tối đa của mảng
                }
                else
                {
                    strings[index] = value;
                    if (ctr < index + 1)
                        ctr = index + 1;
                }
            }
        }
        // lấy số lượng chuỗi được lưu giữ
        public int GetNumEntries()
        {
            return ctr;
        }
        // các biến thành vịên lưu giữ mảng cho bộ chỉ mục
        private string[] strings;
        private int ctr = 0;
    }
    // lớp thực thi
    public class Tester
    {
        static void Main()
        {
            // tạo một đối tượng ListBox mới và khởi tạo
            ListBoxTest lbt = new ListBoxTest("Hello", "World");
            // thêm một số chuỗi vào lbt
            lbt.Add("Who");
            lbt.Add("is");
            lbt.Add("Ngoc");
            lbt.Add("Mun");
            // dùng bộ chỉ mục
            string strTest = "Universe";
            lbt[1] = strTest;
            // truy cập và xuất tất cả các chuỗi
            lbt[10] = "hahaha";
            for (int i = 0; i < lbt.GetNumEntries(); i++)
            {
                Console.WriteLine("lbt[{0}]: {1}", i, lbt[i]);
        }
    }
}
}