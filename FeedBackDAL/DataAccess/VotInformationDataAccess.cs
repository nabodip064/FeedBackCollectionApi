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
        public DataTable GetCustomVotList(string postSearh)
        {
            List<CustomVoteInfo> list = new List<CustomVoteInfo>();
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
                        where p.Post like '%" + postSearh + "%'";
                    context.Database.OpenConnection();
                    var dataReader = command.ExecuteReader();
                    dataTable.Load(dataReader);
                }
            }
            return dataTable;
        }
    }
}
