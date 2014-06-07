using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data;
using System.Reflection;
using System.Linq.Expressions;
using System.ComponentModel;



namespace Models
{
    public class ArticleInformation
    {
        
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime DateAdded { get; set; }

        
    }

    /*-----------------------------------------------------------------------------------------------------------------------------------------------*/
   
    internal sealed partial class Config : global::System.Configuration.ApplicationSettingsBase
    {

        private static Config StandardInstant = ((Config)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Config())));

        public static Config Default
        {
            get
            {
                return StandardInstant;
            }
        }

          [global::System.Configuration.ApplicationScopedSettingAttribute()]
          [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
          [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
          [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\ASPNETDB.MDF;Integrated" +
            " Security=True;User Instance=True")]
        public string DatabaseConnection
        {
            get
            {
                return ((string)(this["DatabaseConnection"]));
            }
        }

       
      
    }
    /*--------------------------------------------------------------------------------------------------------------------------*/
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = "ASPNETDB")]
    public partial class StoryGet : System.Data.Linq.DataContext
    {

        private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();

        
        partial void OnCreation();

        partial void InsertArticle(StoryLink instance);
       
    public StoryGet() :
            base(global::Models.Config.Default.DatabaseConnection, mappingSource)
        {
            OnCreation();
        }
     
        public System.Data.Linq.Table<StoryLink> Articles
        {
            get
            {
                return this.GetTable<StoryLink>();
            }
        }

    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Articles")]
    public partial class StoryLink  
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _ArticleId;

        private string _Title;

        private string _Url;

        private System.DateTime _DateAdded;


        partial void OnCreation();
        public StoryLink()
        {

            OnCreation();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ArticleId", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int ArticleId
        {
            get
            {
                return this._ArticleId;
            }
            set
            {
                if ((this._ArticleId != value))
                {
                    
                    
                    this._ArticleId = value;
                    
                    
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Title", DbType = "NVarChar(256) NOT NULL", CanBeNull = false)]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                if ((this._Title != value))
                {
                    
                    
                    this._Title = value;
                    
                    
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Url", DbType = "NVarChar(256) NOT NULL", CanBeNull = false)]
        public string Url
        {
            get
            {
                return this._Url;
            }
            set
            {
                if ((this._Url != value))
                {
                    
                    
                    this._Url = value;
                    
                    
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_DateAdded", DbType = "DateTime NOT NULL")]
        public System.DateTime DateAdded
        {
            get
            {
                return this._DateAdded;
            }
            set
            {
                if ((this._DateAdded != value))
                {
                    
                    
                    this._DateAdded = value;
                    
                    
                }
            }
        }

       
    } 

}
