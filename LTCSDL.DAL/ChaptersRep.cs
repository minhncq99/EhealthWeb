using LTCSDL.Common.DAL;
using System.Linq;
using LTCSDL.DAL.Models;
using System;
using LTCSDL.Common.Rsp;

namespace LTCSDL.DAL
{
    public class ChaptersRep : GenericRep<EhealthContext, Chapter>
    {
        #region -- Overide --
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Chapter Read(int id)
        {
            var res = All.FirstOrDefault(p => p.ChapterId == id);
            return res;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Remove(int id)
        {
            var m = All.First(p => p.ChapterId == id);
            m = base.Delete(m);
            return m.ChapterId;
        }
        #endregion

        #region -- Methods --
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SingleRsp CreateChapter(string ChapterName)
        {
            var res = new SingleRsp();
            using (var context = new EhealthContext())
            {
                using(var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        Chapter newChapter = new Chapter();
                        newChapter.ChapterId = 0;
                        newChapter.Name = ChapterName;
                        var t = context.Chapters.Add(newChapter);
                        context.SaveChanges();
                        tran.Commit();
                    }
                    catch(Exception ex)
                    {
                        tran.Rollback();
                        res.SetError(ex.StackTrace);
                    }
                }
            }
            return res;
        }

        public SingleRsp UpdateChapter(int ChapterId, string ChapterName)
        {
            var res = new SingleRsp();
            using (var context = new EhealthContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        res.Data = context.Chapters.Find(ChapterId);
                        if (res.Data == null)
                        {
                            res.SetError("Not found!");
                            return res;
                        }
                        else
                        {
                            Chapter newChapter = new Chapter();
                            newChapter.ChapterId = ChapterId;
                            newChapter.Name = ChapterName;
                            context.Entry(res.Data).CurrentValues.SetValues(newChapter);
                            context.SaveChanges();
                            tran.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        res.SetError(ex.StackTrace);
                    }
                }
            }
            return res;
        }

        public SingleRsp DeleteChapter(int ChapterId)
        {
            var res = new SingleRsp();
            using (var context = new EhealthContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        res.Data = context.Chapters.Find(ChapterId);
                        context.Remove(res.Data);
                        context.SaveChanges();
                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        res.SetError(ex.StackTrace);
                    }
                }
            }
            return res;
        }

        public SingleRsp SearchChapter(string keyword, int page, int size)
        {
            var res = new SingleRsp();

            var chap = All.Where(x => x.Name.Contains(keyword));
            var offset = (page - 1) * size;
            var total = chap.Count();
            int totalPage = (total % size) == 0 ? (int)(total / size) : (int)((total / size) + 1);
            var data = chap.OrderBy(x => x.Name).Skip(offset).Take(size).ToList();

            res.Data = new
            {
                Data = data,
                TotalRecord = total,
                TotalPage = totalPage,
                Page = page,
                Size = size,
            };
            return res;
        }
        #endregion
    }
}
