using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public static class Snippet
{
    public static System.String func(System.String input)
    {
        List<TextMatch> textMatches = new List<TextMatch>();
        Regex r1 = new Regex("^[0-9ก-ฮ][ก-ฮ]?[ก-ฮ]$");
        Regex r2 = new Regex("^[0-9]{1,4}$");
        Regex reg = new Regex("[*'\",_&#^@/.:;+? ]");
        foreach (string text in reg.Replace(input.Replace(@"\n", "\n"),"\n").Replace("-", "\n").Split('\n'))
        {
            if (r1.IsMatch(text))
                textMatches.Add(new TextMatch() { Text = text, Match = 1 });
            else if (r2.IsMatch(text))
                textMatches.Add(new TextMatch() { Text = text, Match = 2 });
            else if (GetProvinces().Find(x => x == text) != null)
                textMatches.Add(new TextMatch() { Text = text, Match = 3 });
        }

        string result = "";
        int lastMatch1Index = -1;
        bool match = false;
        do
        {
            int startIndex = 0;
            if (lastMatch1Index >= 0 && textMatches.Count >= lastMatch1Index + 1)
                startIndex = lastMatch1Index + 1;

            lastMatch1Index = textMatches.FindIndex(startIndex, x => x.Match == 1);
            if (lastMatch1Index >= 0)
            {
                if (textMatches.Count >= lastMatch1Index + 3)
                {
                    TextMatch tm1 = textMatches[lastMatch1Index];
                    TextMatch tm2 = textMatches[lastMatch1Index + 1];
                    TextMatch tm3 = textMatches[lastMatch1Index + 2];
                    if (tm1.Match == 1 && tm2.Match == 2 && tm3.Match == 3)
                    {
                        result = string.Format(@"{0}\n{1}\n{2}", tm1.Text, tm2.Text, tm3.Text);
                        match = true;
                    }
                }
            }
            else
            {
                break;
            }
        } while (!match);

        return result;

    }
    public static List<string> GetProvinces()
    {
        List<string> provinces = new List<string>();
        provinces.Add("กระบี่");
        provinces.Add("กรุงเทพมหานคร");
        provinces.Add("กาญจนบุรี");
        provinces.Add("กาฬสินธุ์");
        provinces.Add("กำแพงเพชร");
        provinces.Add("ขอนแก่น");
        provinces.Add("จันทบุรี");
        provinces.Add("ฉะเชิงเทรา");
        provinces.Add("ชลบุรี");
        provinces.Add("ชัยนาท");
        provinces.Add("ชัยภูมิ");
        provinces.Add("ชุมพร");
        provinces.Add("เชียงราย");
        provinces.Add("เชียงใหม่");
        provinces.Add("ตรัง");
        provinces.Add("ตราด");
        provinces.Add("ตาก");
        provinces.Add("นครนายก");
        provinces.Add("นครปฐม");
        provinces.Add("นครพนม");
        provinces.Add("นครราชสีมา");
        provinces.Add("นครศรีธรรมราช");
        provinces.Add("นครสวรรค์");
        provinces.Add("นนทบุรี");
        provinces.Add("นราธิวาส");
        provinces.Add("น่าน");
        provinces.Add("บึงกาฬ");
        provinces.Add("บุรีรัมย์");
        provinces.Add("ปทุมธานี");
        provinces.Add("ประจวบคีรีขันธ์");
        provinces.Add("ปราจีนบุรี");
        provinces.Add("ปัตตานี");
        provinces.Add("พระนครศรีอยุธยา");
        provinces.Add("พะเยา");
        provinces.Add("พังงา");
        provinces.Add("พัทลุง");
        provinces.Add("พิจิตร");
        provinces.Add("พิษณุโลก");
        provinces.Add("เพชรบุรี");
        provinces.Add("เพชรบูรณ์");
        provinces.Add("แพร่");
        provinces.Add("ภูเก็ต");
        provinces.Add("มหาสารคาม");
        provinces.Add("มุกดาหาร");
        provinces.Add("แม่ฮ่องสอน");
        provinces.Add("ยโสธร");
        provinces.Add("ยะลา");
        provinces.Add("ร้อยเอ็ด");
        provinces.Add("ระนอง");
        provinces.Add("ระยอง");
        provinces.Add("ราชบุรี");
        provinces.Add("ลพบุรี");
        provinces.Add("ลำปาง");
        provinces.Add("ลำพูน");
        provinces.Add("เลย");
        provinces.Add("ศรีสะเกษ");
        provinces.Add("สกลนคร");
        provinces.Add("สงขลา");
        provinces.Add("สตูล");
        provinces.Add("สมุทรปราการ");
        provinces.Add("สมุทรสงคราม");
        provinces.Add("สมุทรสาคร");
        provinces.Add("สระแก้ว");
        provinces.Add("สระบุรี");
        provinces.Add("สิงห์บุรี");
        provinces.Add("สุโขทัย");
        provinces.Add("สุพรรณบุรี");
        provinces.Add("สุราษฎร์ธานี");
        provinces.Add("สุรินทร์");
        provinces.Add("หนองคาย");
        provinces.Add("หนองบัวลำภู");
        provinces.Add("อ่างทอง");
        provinces.Add("อำนาจเจริญ");
        provinces.Add("อุดรธานี");
        provinces.Add("อุตรดิตถ์");
        provinces.Add("อุทัยธานี");
        provinces.Add("อุบลราชธานี");
        provinces.Add("เบตง");
        return provinces;

    }
    class TextMatch
    {
        public string Text { get; set; }
        public int Match { get; set; }
    }

}