using FeedBackDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using FeedBackDAL.DataAccess;
using System.Data;

namespace FeedBackBLL.Provider
{
    public class VoteInfromationProvider
    {
        private VotInformationDataAccess _dataAccess;
        public VoteInfromationProvider()
        {
            _dataAccess = new VotInformationDataAccess();
        }
        public List<CustomVoteInfo> GetCustomVoteInfos(string postSerach)
        {
            List<CustomVoteInfo> votList = new List<CustomVoteInfo>();
            DataTable dt = _dataAccess.GetCustomVotList(postSerach);
            if(dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach(DataRow row in dt.Rows)
                    {
                        CustomVoteInfo entity = new CustomVoteInfo();
                        entity.Post = row["Post"].ToString();
                        entity.Comment = row["Comment"].ToString();
                        entity.UserID = row["UserID"].ToString();
                        entity.CommentDate = Convert.ToDateTime(row["CommentDate"]);
                        entity.AggreCount = Convert.ToInt32(row["AggreCount"]);
                        entity.DisAggreCount = Convert.ToInt32(row["AggreCount"]);
                        votList.Add(entity);
                    }
                }
            }
            return votList;
        }
    }
}
