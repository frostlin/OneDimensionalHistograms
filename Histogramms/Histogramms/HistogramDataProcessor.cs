using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogramms
{
    class HistogramDataProcessor
    {
        public class Element
        {
            public int value;
            public int count;
            public Element(int v)
            {
                value = v;
                count = 1;
            }
        }

        public List<Element> Process(int[] array)
        {
            List<Element> histogramData = new List<Element>();
            bool flag = false;
            for (int i = 0; i < array.Length; ++i)
            {
                for (int j = 0; j < histogramData.Count; ++j)
                {
                    if (array[i] == histogramData[j].value)
                    {
                        histogramData[j].count++;
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    flag = false;
                    continue;
                }
                histogramData.Add(new Element(array[i]));
            }

            int len = histogramData.Count;
            for (int j = len - 1; j > 0; --j)
                for (int i = 0; i < j; ++i)
                    if (histogramData[i].value > histogramData[i + 1].value)
                    {
                        int temp = histogramData[i].value;
                        histogramData[i].value = histogramData[i + 1].value;
                        histogramData[i + 1].value = temp;
                    }
            return histogramData;
        }

    }
}
