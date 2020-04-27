using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp1.API
{
    public class InformationsService
    {
        PictureService pictureService = new PictureService();
        TagsService tagsService = new TagsService();
        public Informations saveInformations(string path,String tag, String value)
        {
            Picture savedPicture = pictureService.createPicture(path);
            
            using (Model1Container context = new Model1Container())
            {
                Tags tagFomDB = context.TagsSet
                    .Where(t => t.name == tag)
                    .FirstOrDefault();

                Informations informations = new Informations();
                informations.picture_id = savedPicture;
                informations.description = value;
                if (tagFomDB != null)
                {
                    context.Entry(tagFomDB).State = EntityState.Unchanged;
                    informations.tag_id = tagFomDB;
                }
                else
                {
                    Tags savedTag = tagsService.createTags(tag);
                    informations.tag_id = savedTag;
                }
                context.InformationsSet.Add(informations);
                context.SaveChanges();
                return informations;
            }
        }

        public List<String> displaySearchResults(String description, String tag)
        {
            List<String> results = new List<string>();

            if (tag != "" && description != "")
            {
                using (Model1Container context = new Model1Container())
                {
                    List<Informations> infos = context.InformationsSet.Where(info => info.tag_id.name.Equals(tag) && info.description.Contains(description) && info.picture_id.deleted == false).ToList();
                    infos.ForEach(delegate (Informations info) { results.Add(info.picture_id.path); });
                }
            }

            if (description != "")
            {
                using (Model1Container context = new Model1Container())
                {
                    List<Informations> infos = context.InformationsSet.Where(info => info.description.Contains(description) && info.picture_id.deleted == false).ToList();
                    infos.ForEach(delegate (Informations info) { results.Add(info.picture_id.path); });
                }
            }

            if (tag != "")
            {
                using (Model1Container context = new Model1Container())
                {
                    List<Informations> infos = context.InformationsSet.Where(info => info.tag_id.name.Equals(tag) && info.picture_id.deleted == false).ToList();
                    infos.ForEach(delegate (Informations info) { results.Add(info.picture_id.path); });
                }
            }
            return results;
        }
    }
}
