using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace Topical_Memory_System
{
	public class PrintVerses
	{
		public static void Print(List<Verse> incomingVerses, string selection)
		{
			try
			{
				Verse[][] verses = MakeArray(incomingVerses);

				ApplicationClass app = new ApplicationClass();
				Document doc = new Document();

				object missing = System.Reflection.Missing.Value;
				object b = false;
				object c = 0;
				object d = false;
				object pageBreak = WdBreakType.wdPageBreak;
				doc = app.Documents.Add(ref missing, ref b, ref c, ref d);

				doc.Activate();

				object autoFit1 = true;
				object autoFit2 = true;

				app.Selection.Font.Size = 12;
				app.Selection.Font.Name = "Times New Roman";

				Table table = app.Selection.Tables.Add(app.Selection.Range, verses.Length, 2, ref autoFit1, ref autoFit2);
				table.Borders.Enable = 0;

				for (int i = 0; i < verses.Length; i++)
				{
					table.Cell(i + 1, 1).Column.SetWidth(250, WdRulerStyle.wdAdjustSameWidth);
					table.Cell(i + 1, 2).Column.SetWidth(250, WdRulerStyle.wdAdjustSameWidth);
					table.Cell(i + 1, 1).BottomPadding = ((float)40);
					table.Cell(i + 1, 2).BottomPadding = ((float)40);

					for (int j = 0; j < 2; j++)
					{
						if (verses[i][j] != null)
						{
							if (selection == "verses")
							{
								table.Cell(i + 1, j + 1).Range.Text = verses[i][j].getVerseData() + Constants.NewLine;
							}
							else if (selection == "references")
							{
								table.Cell(i + 1, j + 1).Range.Text = verses[i][j].getReference() + Constants.NewLine;
							}
							else
							{
								table.Cell(i + 1, j + 1).Range.Text = verses[i][j].getReference() + Constants.NewLine + Constants.NewLine + verses[i][j].getVerseData();
							}
						}
					}
				}

				app.Visible = true;
			}
			catch (Exception)
			{
				MessageBox.Show("A problem occurred while creating printable verses.");
			}
        }
		
		public static Verse[][] MakeArray(List<Verse> incomingVerses)
		{
			try
			{
				int num = ((int)(Math.Ceiling(((double)incomingVerses.Count) / (2.0))));
				Verse[][] result = new Verse[num][];
				int index = 0;
				for (int i = 0; i < num; i++)
				{
					result[i] = new Verse[2];
					result[i][0] = incomingVerses[index++];
					if (index < incomingVerses.Count)
					{
						result[i][1] = incomingVerses[index++];
					}
				}
				return result;
			}
			catch (Exception e)
			{
				throw e;
			}
		}
	}
}
