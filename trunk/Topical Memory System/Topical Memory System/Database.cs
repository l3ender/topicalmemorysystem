using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Topical_Memory_System
{
	public class Database
	{

		public Database()
		{

		}

		public List<VersePack> LoadCustomVerses()
		{
			List<VersePack> vps = new List<VersePack>();
			try
			{
				List<string> groupNames = LoadCustomGroupNames();
				foreach (string name in groupNames)
				{
					vps.Add(LoadCustomVersesByGroupName(name));
				}
			}
			catch (Exception)
			{
				throw new Exception();
			}

			return vps;
		}

		public List<string> LoadCustomGroupNames()
		{
			List<string> names = new List<string>();
			try
			{
				SQLiteConnection conn;
				SQLiteCommand cmd;
				SQLiteDataReader dataReader;

				//set up connection
				conn = new SQLiteConnection(Constants.DatabaseConnectionString);
				conn.Open();
				cmd = conn.CreateCommand();

				//select statement
				cmd.CommandText = "SELECT Name FROM CustomGroups;";
				dataReader = cmd.ExecuteReader();

				int numColumns = dataReader.FieldCount;
				while (dataReader.Read())
				{
					names.Add(dataReader[0].ToString());
				}
				conn.Close();
			}
			catch (Exception)
			{
				throw new Exception();
			}

			return names;
		}

		public VersePack LoadCustomVersesByGroupName(string incomingGroupName)
		{
			VersePack vp = new VersePack();
			try
			{
				vp.SetName(incomingGroupName);

				SQLiteConnection conn;
				SQLiteCommand cmd;
				SQLiteDataReader dataReader;

				//set up connection
				conn = new SQLiteConnection(Constants.DatabaseConnectionString);
				conn.Open();
				cmd = conn.CreateCommand();

				//select statement
				cmd.CommandText = "SELECT V.Book, V.Chapter, V.VerseNumbers, V.VerseData, G.Name FROM CustomVerses V " +
					"INNER JOIN CustomGroups G ON V.GroupNameID = G.ID " +
					"WHERE (G.Name = @groupName);";
				SQLiteParameter groupName = new SQLiteParameter("@groupName");
				cmd.Parameters.Add(groupName);
				groupName.Value = incomingGroupName;

				dataReader = cmd.ExecuteReader();

				int numColumns = dataReader.FieldCount;
				while (dataReader.Read())
				{
					Verse v = new Verse(dataReader[0].ToString(), Convert.ToInt32(dataReader[1]), dataReader[2].ToString(),
						dataReader[4].ToString(), "", "", dataReader[3].ToString(), "", "", "", "", false);
					vp.AddVerse(v);
				}
				conn.Close();
			}
			catch (Exception)
			{
				throw new Exception();
			}

			return vp;
		}

		public int GetCustomGroupIdByName(string incomingGroupName)
		{
			int result = -1;
			try
			{
				SQLiteConnection conn;
				SQLiteCommand cmd;
				SQLiteDataReader dataReader;

				//set up connection
				conn = new SQLiteConnection(Constants.DatabaseConnectionString);
				conn.Open();
				cmd = conn.CreateCommand();

				//get group name ID
				cmd.CommandText = "SELECT ID FROM CustomGroups WHERE (Name = @groupName) LIMIT 0, 1";
				SQLiteParameter groupName = new SQLiteParameter("@groupName");
				cmd.Parameters.Add(groupName);
				groupName.Value = incomingGroupName;

				dataReader = cmd.ExecuteReader();

				int numColumns = dataReader.FieldCount;
				while (dataReader.Read())
				{
					result = Convert.ToInt32(dataReader[0]);
				}

				conn.Close();
			}
			catch (Exception)
			{
				throw new Exception();
			}

			return result;
		}

		public void SaveVerseToDatabase(string incomingBook, int incomingChapter, string incomingVerseNumbers, 
			string incomingVerseData, string incomingGroupName)
		{
			try
			{
				int id = GetCustomGroupIdByName(incomingGroupName);

				SQLiteConnection conn;
				SQLiteCommand cmd;

				//set up connection
				conn = new SQLiteConnection(Constants.DatabaseConnectionString);
				conn.Open();
				cmd = conn.CreateCommand();

				//insert statement
				cmd.CommandText = @"INSERT INTO CustomVerses (Book, Chapter, VerseNumbers, VerseData, GroupNameID) 
								VALUES (@book, @chapter, @verseNumbers, @verseData, @groupNameId);";
				SQLiteParameter book = new SQLiteParameter("@book");
				cmd.Parameters.Add(book);
				SQLiteParameter chapter = new SQLiteParameter("@chapter");
				cmd.Parameters.Add(chapter);
				SQLiteParameter verseNumbers = new SQLiteParameter("@verseNumbers");
				cmd.Parameters.Add(verseNumbers);
				SQLiteParameter verseData = new SQLiteParameter("@verseData");
				cmd.Parameters.Add(verseData);
				SQLiteParameter groupNameId = new SQLiteParameter("@groupNameId");
				cmd.Parameters.Add(groupNameId);

				book.Value = incomingBook;
				chapter.Value = incomingChapter;
				verseNumbers.Value = incomingVerseNumbers;
				verseData.Value = incomingVerseData;
				groupNameId.Value = id;

				cmd.ExecuteNonQuery();

				conn.Close();
			}
			catch (Exception)
			{
				throw new Exception();
			}
		}

		public void SaveMultipleVersesToDatabase(List<Verse> verses, string groupName)
		{
			try
			{
				int id = GetCustomGroupIdByName(groupName);

				SQLiteConnection conn;
				SQLiteCommand cmd;

				//set up connection
				conn = new SQLiteConnection(Constants.DatabaseConnectionString);
				conn.Open();
				cmd = conn.CreateCommand();

				//insert statement
				cmd.CommandText = @"INSERT INTO CustomVerses (Book, Chapter, VerseNumbers, VerseData, GroupNameID) 
								VALUES (@book, @chapter, @verseNumbers, @verseData, @groupNameId);";
				SQLiteParameter book = new SQLiteParameter("@book");
				cmd.Parameters.Add(book);
				SQLiteParameter chapter = new SQLiteParameter("@chapter");
				cmd.Parameters.Add(chapter);
				SQLiteParameter verseNumbers = new SQLiteParameter("@verseNumbers");
				cmd.Parameters.Add(verseNumbers);
				SQLiteParameter verseData = new SQLiteParameter("@verseData");
				cmd.Parameters.Add(verseData);
				SQLiteParameter groupNameId = new SQLiteParameter("@groupNameId");
				cmd.Parameters.Add(groupNameId);

				foreach (Verse v in verses)
				{
					book.Value = v.getBook();
					chapter.Value = v.getChapter();
					verseNumbers.Value = v.getVerseNumbers();
					verseData.Value = v.getVerseData();
					groupNameId.Value = id;
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			catch (Exception)
			{
				throw new Exception();
			}
		}

		public void UpdateGroupName(string incomingOldName, string incomingNewName)
		{
			try
			{
				SQLiteConnection conn;
				SQLiteCommand cmd;

				//set up connection
				conn = new SQLiteConnection(Constants.DatabaseConnectionString);
				conn.Open();
				cmd = conn.CreateCommand();

				//insert statement
				cmd.CommandText = "UPDATE CustomGroups SET Name = @newName WHERE (CustomGroups.Name = @oldName);";
				SQLiteParameter newName = new SQLiteParameter("@newName");
				cmd.Parameters.Add(newName);
				SQLiteParameter oldName = new SQLiteParameter("@oldName");
				cmd.Parameters.Add(oldName);

				newName.Value = incomingNewName;
				oldName.Value = incomingOldName;

				cmd.ExecuteNonQuery();

				int result = cmd.ExecuteNonQuery();
				conn.Close();
			}
			catch (Exception)
			{
				throw new Exception();
			}
		}

		public void UpdateVerse(Verse oldVerse, Verse newVerse)
		{
			try
			{
				SQLiteConnection conn;
				SQLiteCommand cmd;

				//set up connection
				conn = new SQLiteConnection(Constants.DatabaseConnectionString);
				conn.Open();
				cmd = conn.CreateCommand();

				//insert statement
				cmd.CommandText = @"UPDATE CustomVerses 
								SET Book = @newVerseBook, Chapter = @newVerseChapter, VerseNumbers = @newVerseNumbers, VerseData = @newVerseData 
								WHERE (CustomVerses.Book = @oldVerseBook) AND (CustomVerses.Chapter = @oldVerseChapter) 
									AND (CustomVerses.VerseNumbers = @oldVerseNumbers) AND (CustomVerses.VerseData = @oldVerseData);";
				SQLiteParameter newVerseBook = new SQLiteParameter("@newVerseBook");
				cmd.Parameters.Add(newVerseBook);
				newVerseBook.Value = newVerse.getBook();
				SQLiteParameter newVerseChapter = new SQLiteParameter("@newVerseChapter");
				cmd.Parameters.Add(newVerseChapter);
				newVerseChapter.Value = newVerse.getChapter();
				SQLiteParameter newVerseNumbers = new SQLiteParameter("@newVerseNumbers");
				cmd.Parameters.Add(newVerseNumbers);
				newVerseNumbers.Value = newVerse.getVerseNumbers();
				SQLiteParameter newVerseData = new SQLiteParameter("@newVerseData");
				cmd.Parameters.Add(newVerseData);
				newVerseData.Value = newVerse.getVerseData();

				SQLiteParameter oldVerseBook = new SQLiteParameter("@oldVerseBook");
				cmd.Parameters.Add(oldVerseBook);
				oldVerseBook.Value = oldVerse.getBook();
				SQLiteParameter oldVerseChapter = new SQLiteParameter("@oldVerseChapter");
				cmd.Parameters.Add(oldVerseChapter);
				oldVerseChapter.Value = oldVerse.getChapter();
				SQLiteParameter oldVerseNumbers = new SQLiteParameter("@oldVerseNumbers");
				cmd.Parameters.Add(oldVerseNumbers);
				oldVerseNumbers.Value = oldVerse.getVerseNumbers();
				SQLiteParameter oldVerseData = new SQLiteParameter("@oldVerseData");
				cmd.Parameters.Add(oldVerseData);
				oldVerseData.Value = oldVerse.getVerseData();

				cmd.ExecuteNonQuery();

				int result = cmd.ExecuteNonQuery();
				conn.Close();
			}
			catch (Exception)
			{
				throw new Exception();
			}
		}

		public void DeleteVerse(Verse v)
		{
			try
			{
				SQLiteConnection conn;
				SQLiteCommand cmd;

				//set up connection
				conn = new SQLiteConnection(Constants.DatabaseConnectionString);
				conn.Open();
				cmd = conn.CreateCommand();

				//insert statement
				cmd.CommandText = @"DELETE FROM CustomVerses 
								WHERE (CustomVerses.Book = @book) AND (CustomVerses.Chapter = @chapter) 
									AND (CustomVerses.VerseNumbers = @verseNumbers) AND (CustomVerses.VerseData = @verseData);";
				SQLiteParameter book = new SQLiteParameter("@book");
				cmd.Parameters.Add(book);
				book.Value = v.getBook();
				SQLiteParameter chapter = new SQLiteParameter("@chapter");
				cmd.Parameters.Add(chapter);
				chapter.Value = v.getChapter();
				SQLiteParameter verseNumbers = new SQLiteParameter("@verseNumbers");
				cmd.Parameters.Add(verseNumbers);
				verseNumbers.Value = v.getVerseNumbers();
				SQLiteParameter verseData = new SQLiteParameter("@verseData");
				cmd.Parameters.Add(verseData);
				verseData.Value = v.getVerseData();

				cmd.ExecuteNonQuery();

				int result = cmd.ExecuteNonQuery();
				conn.Close();
			}
			catch (Exception)
			{
				throw new Exception();
			}
		}
	}
}
