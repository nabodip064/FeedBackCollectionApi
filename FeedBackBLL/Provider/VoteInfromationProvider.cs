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
        public List<CollectionDetailsInfo> GetCustomVoteInfos(string postSerach)
        {
            List<CollectionDetailsInfo> detailsInfoList = new List<CollectionDetailsInfo>();
            DataTable postDt = _dataAccess.GetPostList(postSerach);
            if(postDt!= null)
            {
                if(postDt.Rows.Count > 0)
                {
                    foreach(DataRow postRow in postDt.Rows)
                    {
                        CollectionDetailsInfo detailsInfo = new CollectionDetailsInfo();
                        detailsInfo.PostID = Convert.ToInt32(postRow["PostID"]);
                        detailsInfo.Post = postRow["Post"].ToString();
                        detailsInfo.UserID = postRow["UserID"].ToString();
                        detailsInfo.CreateDate = Convert.ToDateTime(postRow["CreateDate"]);
                        detailsInfo.TotalComment = Convert.ToInt32(postRow["TotalComment"]);
                        detailsInfo.VotList = this.GetVotList(detailsInfo.PostID);
                        detailsInfoList.Add(detailsInfo);
                    }
                }
            }
            
            return detailsInfoList;
        }

        private List<CustomVoteInfo> GetVotList(int postID)
        {
            List<CustomVoteInfo> votList = new List<CustomVoteInfo>();
            DataTable dt = _dataAccess.GetCustomVotList(postID);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        CustomVoteInfo entity = new CustomVoteInfo();
                        entity.Post = row["Post"].ToString();
                        entity.Comment = row["Comment"].ToString();
                        entity.UserID = row["UserID"].ToString();
                        entity.CommentDate = Convert.ToDateTime(row["CommentDate"]);
                        entity.AggreCount = Convert.ToInt32(row["AggreCount"]);
                        entity.DisAggreCount = Convert.ToInt32(row["DisAggreCount"]);
                        votList.Add(entity);
                    }
                }
            }
            return votList;
        }
    }
}
