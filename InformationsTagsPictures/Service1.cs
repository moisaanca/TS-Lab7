using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WindowsFormsApp1;
using WindowsFormsApp1.API;
namespace InformationsTagsPictures
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public Picture createPicture(string path)
        {
            return createPictureMethod(path);
        }

        public Tags createTags(string name)
        {
            return createTagsMethod(name);
        }

        public void deletePicture(string path)
        {
            deletePictureMethod(path);
        }

        public Informations saveInformations(string path, string tag, string value)
        {
            return saveInformationsMethod(path, tag, value);
        }

        public List<string> displaySearchResults(string description, string tag)
        {
            return displaySearchResultsMethod(description, tag);
        }

        public List<string> getTags()
        {
            return getTagsMethod();
        }

        public Tags saveTag(string name)
        {
            return saveTagMethod(name);
        }

        public Picture createPictureMethod(string path)
        {
            char[] separator = { '\\' };
            Picture picture = new Picture();
            picture.path = path;
            picture.deleted = false;
            picture.full_name = path.Split(separator)[path.Split(separator).Length - 1];
            picture.created_at = DateTime.Now;
            return picture;
        }

        public void deletePictureMethod(String path)
        {

            using (Model1Container context = new Model1Container())
            {
                context.Configuration.ProxyCreationEnabled = false;
                context.Picture.Single(a => a.path == path).deleted = true;
                context.SaveChanges();
            }
        }

        public Tags createTagsMethod(string name)
        {
            Tags tag = new Tags() { name = name };
            return tag;
        }

        public List<String> getTagsMethod()
        {
            List<String> tagNames = new List<string>();
            using (Model1Container context = new Model1Container())
            {
                context.Configuration.ProxyCreationEnabled = false; var configTag = new MapperConfiguration(cfg => {
                    cfg.CreateMap<Tags, WindowsFormsApp1.Tags>();
                });
                IMapper mapperTag = configTag.CreateMapper();
                Action<WindowsFormsApp1.Tags> p = delegate (WindowsFormsApp1.Tags tag) { tagNames.Add(tag.name); };
                context.TagsSet.ToList().ForEach(p);
                return tagNames;
            }
        }

        public Tags saveTagMethod(String name)
        {
            using (Model1Container context = new Model1Container())
            {
                context.Configuration.ProxyCreationEnabled = false;
                Tags tag = createTagsMethod(name);
                context.TagsSet.Add(new WindowsFormsApp1.Tags { name = name });
                context.SaveChanges();
                return tag;
            }
        }

        public Informations saveInformationsMethod(string path, String tag, String value)
        {
            
            Picture savedPicture = createPictureMethod(path);


            using (Model1Container context = new Model1Container())
            {
                context.Configuration.ProxyCreationEnabled = false;
                WindowsFormsApp1.Tags tagWF = context.TagsSet
                    .Where(t => t.name == tag)
                    .FirstOrDefault();
                Tags tagFromDB = new Tags() { Id = tagWF.Id, name = tagWF.name };

                Informations informations = new Informations();
                informations.picture_id = savedPicture;
                informations.description = value;
                if (tagFromDB != null)
                {
                    context.Entry(tagFromDB).State = EntityState.Unchanged;
                    informations.tag_id = tagFromDB;
                }
                else
                {
                    Tags savedTag = createTagsMethod(tag);
                    informations.tag_id = savedTag;
                }
                var configPic = new MapperConfiguration(cfg => {
                    cfg.CreateMap<Picture, WindowsFormsApp1.Picture>();
                });
                IMapper mapperPicture = configPic.CreateMapper();
                var configTag = new MapperConfiguration(cfg => {
                    cfg.CreateMap<Tags, WindowsFormsApp1.Tags>();
                });
                IMapper mapperTag = configTag.CreateMapper();
                var configInfo = new MapperConfiguration(cfg => {
                    cfg.CreateMap<Informations, WindowsFormsApp1.Informations>();
                });
                IMapper mapperInfo = configInfo.CreateMapper();

                //WindowsFormsApp1.Informations info = new WindowsFormsApp1.Informations { description = informations.description, Id = informations.Id, picture_id = mapperPicture.Map<Picture, WindowsFormsApp1.Picture>(informations.picture_id), tag_id = mapperTag.Map<Tags, WindowsFormsApp1.Tags>(informations.tag_id) };
                context.InformationsSet.Add(mapperInfo.Map< Informations, WindowsFormsApp1.Informations>(informations));
                context.SaveChanges();
                return informations;
            }
        }

        public List<String> displaySearchResultsMethod(String description, String tag)
        {
            List<String> results = new List<string>();
            var configInfo = new MapperConfiguration(cfg => {
                cfg.CreateMap<Informations, WindowsFormsApp1.Informations>();
            });
            IMapper mapperInfo = configInfo.CreateMapper();

            if (tag != "" && description != "")
            {
                using (Model1Container context = new Model1Container())
                {
                    context.Configuration.ProxyCreationEnabled = false;
                    List<WindowsFormsApp1.Informations> infos = context.InformationsSet.Where(info => info.tag_id.name.Equals(tag) && info.description.Contains(description) && info.picture_id.deleted == false).ToList();
                    infos.ForEach(delegate (WindowsFormsApp1.Informations info) { results.Add(info.picture_id.path); });
                }
            }

            if (description != "")
            {
                using (Model1Container context = new Model1Container())
                {
                    context.Configuration.ProxyCreationEnabled = false;
                    List<WindowsFormsApp1.Informations> infos = context.InformationsSet.Where(info => info.description.Contains(description) && info.picture_id.deleted == false).ToList();
                    infos.ForEach(delegate (WindowsFormsApp1.Informations info) { results.Add(info.picture_id.path); });
                }
            }

            if (tag != "")
            {
                using (Model1Container context = new Model1Container())
                {
                    context.Configuration.ProxyCreationEnabled = false;
                    List<WindowsFormsApp1.Informations> infos = context.InformationsSet.Where(info => info.tag_id.name.Equals(tag) && info.picture_id.deleted == false).ToList();
                    infos.ForEach(delegate (WindowsFormsApp1.Informations info) { results.Add(info.picture_id.path); });
                }
            }
            return results;
        }
    }
}
