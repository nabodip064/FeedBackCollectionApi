using FeedBackDAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FeedBackDAL.DataAccess
{
    public class VotInformationDataAccess
    {
        public DataTable GetCustomVotList(int postID)
        {
            var dataTable = new DataTable();
            using (var context = new FeedBackDBContext())
            {
                using (var command = context.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = @"select p.Post as Post, c.Comment as Comment, u.UserID as UserID, c.CreateDate as CommentDate,
                        (select sum(ID) from VoteInfo v where v.CommentID = c.ID and v.AggreByVote = 1) as AggreCount,
	                    (select sum(ID) from VoteInfo v where v.CommentID = c.ID and v.AggreByVote = 0) as DisAggreCount from CommentInfo as c
                        inner join PostInfo p on c.PostID = p.ID
                        inner join UserInfo u on u.ID = c.UserID
                        where p.ID = " + postID.ToString();
                    context.Database.OpenConnection();
                    var dataReader = command.ExecuteReader();
                    dataTable.Load(dataReader);
                }
            }
            return dataTable;
        }
        public DataTable GetPostList(string postSearh)
        {
            var dataTable = new DataTable();
            using (var context = new FeedBackDBContext())
            {
                using (var command = context.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = @"SELECT p.ID as  PostID, p.Post, u.UserID , p.CreateDate, sum(c.ID) as TotalComment from PostInfo as p
                        inner join UserInfo u on u.ID = p.UserID
                        inner join CommentInfo c on c.PostID = p.ID
                        where p.Post like '%" + postSearh +
                        "%' Group by p.ID, p.Post, u.UserID , p.CreateDate";
                    context.Database.OpenConnection();
                    var dataReader = command.ExecuteReader();
                    dataTable.Load(dataReader);
                }
            }
            return dataTable;
        }
    }
}
