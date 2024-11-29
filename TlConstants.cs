using System;
using System.Collections.Generic;
using System.Text;

namespace TL.Framework.Utility
{
    public static class TlConstants
    {

        #region Common
        public static string JSON_CONTENT_TYPE = "application/json";
        public static string HH_MM_FORMAT = "HH:mm";
        public static string HH_MM_DEFAULT = "00:00";
        #endregion


        public const string VALID_TOKEN_TEXT = "Valid Token";

        #region Route Parameters
        public const string ROUTE_URL_TOKEN = "Token";
        public const string ROUTE_URL_IS_VALID_TOKEN = "IsValidToken";

        // Article
        public const string ROUTE_URL_EDUCATION_ARTICLES = "api/articles";
        public const string ROUTE_URL_EDUCATION_ARTICLE_BY_ID = "api/articles/{id}";
        public const string ROUTE_URL_EDUCATION_SAVE_ARTICLE = "api/article";
        public const string ROUTE_URL_EDUCATION_UPDATE_ARTICLE = "api/articles/{id}";
        public const string ROUTE_URL_EDUCATION_DELETE_ARTICLE = "api/articles/{id}";

        //TenantUser
        public const string ROUTE_URL_TENANTUSER_SIGNUP = "api/signup";
        public const string ROUTE_URL_TENANTUSER_SENDOTP = "api/send_otp";
        public const string ROUTE_URL_TENANTUSER_VERIFYOTP = "api/verify_otp";
        public const string ROUTE_URL_TENANTUSER_FORGOTPASSWORD = "api/forgot_password";
        public const string ROUTE_URL_TENANTUSER_RESETPASSWORD = "api/reset_password";
        public const string ROUTE_URL_TENANTUSER_LOGIN = "api/tenantlogin";
        public const string ROUTE_URL_TENANTUSER_APPROVEORREJECT = "api/approveOrRejectUser";

        //Accounts
        public const string ROUTE_URL_TENANTUSER_GETACCOUNT = "api/accounts";
        public const string ROUTE_URL_TENANTUSER_ACCOUNT_BY_ID = "api/accounts/{id}";
        public const string ROUTE_URL_TENANTUSER_SAVEACCOUNT = "api/accounts";
        public const string ROUTE_URL_TENANTUSER_UPDATE_ACCOUNT = "api/accounts";
        public const string ROUTE_URL_TENANTUSER_DELETE_ACCOUNT = "api/accounts/{id}";

        //Project
        public const string ROUTE_URL_TENANTUSER_GETPROJECT = "api/projects";
        public const string ROUTE_URL_TENANTUSER_PROJECT_BY_ID = "api/projects/{id}";
        public const string ROUTE_URL_TENANTUSER_SAVEPROJECT = "api/projects";
        public const string ROUTE_URL_TENANTUSER_UPDATE_PROJECT = "api/projects";
        public const string ROUTE_URL_TENANTUSER_DELETE_PROJECT = "api/projects/{id}";

        //Towers
        public const string ROUTE_URL_TENANTUSER_GETTOWER = "api/towers";
        public const string ROUTE_URL_TENANTUSER_TOWER_BY_ID = "api/towers/{id}";
        public const string ROUTE_URL_TENANTUSER_SAVETOWER = "api/towers";
        public const string ROUTE_URL_TENANTUSER_UPDATE_TOWER = "api/towers";
        public const string ROUTE_URL_TENANTUSER_DELETE_TOWER = "api/towers/{id}";

        //Floors
        public const string ROUTE_URL_TENANTUSER_GETFLOOR = "api/floors";
        public const string ROUTE_URL_TENANTUSER_FLOOR_BY_ID = "api/floors/{id}";
        public const string ROUTE_URL_TENANTUSER_SAVEFLOOR = "api/floors";
        public const string ROUTE_URL_TENANTUSER_UPDATE_FLOOR = "api/floors";
        public const string ROUTE_URL_TENANTUSER_DELETE_FLOOR = "api/floors/{id}";

        //Unit
        public const string ROUTE_URL_TENANTUSER_GETUNIT = "api/units";
        public const string ROUTE_URL_TENANTUSER_UNIT_BY_ID = "api/units/{id}";
        public const string ROUTE_URL_TENANTUSER_SAVEUNIT = "api/units";
        public const string ROUTE_URL_TENANTUSER_UPDATE_UNIT = "api/units";
        public const string ROUTE_URL_TENANTUSER_DELETE_UNIT = "api/units/{id}";

        //GreenInitiative
        public const string ROUTE_URL_GREENINITIATIVE_GREENINITIATIVE = "api/greeninitiative";
        public const string ROUTE_URL_GREENINITIATIVE_GREENINITIATIVE_BY_ID = "api/greeninitiative/{id}";
        public const string ROUTE_URL_GREENINITIATIVE_SAVEGREENINITIATIVE = "api/greeninitiative";
        public const string ROUTE_URL_GREENINITIATIVE_UPDATE_GREENINITIATIVE = "api/greeninitiative";
        public const string ROUTE_URL_GREENINITIATIVE_DELETE_GREENINITIATIVE = "api/greeninitiative/{id}";

        //EcoFriendlyTip
        public const string ROUTE_URL_ECOFRIENDLYTIP_ECOFRIENDLYTIP = "api/ecofriendlytip";
        public const string ROUTE_URL_ECOFRIENDLYTIP_ECOFRIENDLYTIP_BY_ID = "api/ecofriendlytip/{id}";
        public const string ROUTE_URL_ECOFRIENDLYTIP_SAVEECOFRIENDLYTIP = "api/ecofriendlytip";
        public const string ROUTE_URL_ECOFRIENDLYTIP_UPDATE_ECOFRIENDLYTIP = "api/ecofriendlytip";
        public const string ROUTE_URL_ECOFRIENDLYTIP_DELETE_ECOFRIENDLYTIP = "api/ecofriendlytip/{id}";

        //Question
        public const string ROUTE_URL_QUESTION_QUESTION = "api/question";
        public const string ROUTE_URL_QUESTION_QUESTION_BY_ID = "api/question/{id}";
        public const string ROUTE_URL_QUESTION_SAVEQUESTION = "api/question";
        public const string ROUTE_URL_QUESTION_UPDATE_QUESTION = "api/question";
        public const string ROUTE_URL_QUESTION_DELETE_QUESTION = "api/question/{id}";

        //UserQuizResult
        public const string ROUTE_URL_UQR_USERQUIZRESULT = "api/userquizresult";
        public const string ROUTE_URL_UQR_USERQUIZRESULT_BY_ID = "api/userquizresult/{id}";
        public const string ROUTE_URL_UQR_SAVEUSERQUIZRESULT = "api/userquizresult";

        //User
        public const string ROUTE_URL_USER_FORGOTPASSWORD = "api/auth/password/forgot";
        public const string ROUTE_URL_USER_RESETPASSWORD = "api/auth/password/reset";
        public const string ROUTE_URL_USER_VERIFYUSEROTP = "api/auth/verifyuserotp";
        public const string ROUTE_URL_USER_REGISTER = "api/auth/register";

        public const string ROUTE_URL_USER_SAVEUSER = "api/User";
        public const string ROUTE_URL_USER_UPDATEUSER = "api/User/{id}";
        public const string ROUTE_URL_USER_DELETEUSER = "api/User/{id}";
        public const string ROUTE_URL_USER_USER = "api/User";
        public const string ROUTE_URL_USER_USERBYID = "api/User/{id}";
        public const string ROUTE_URL_USER_USERBYUNIT = "api/User/byUnit/{id}";

        public const string ROUTE_URL_USER_FETCHUSERLOG = "api/UserAccessLog";
        public const string ROUTE_URL_USER_SAVEUSERLOG = "api/UserAccessLog";

        public const string ROUTE_URL_GETCOMMITTEEMEMBER = "api/committee_members";
        public const string ROUTE_URL_GETCOMMITTEEMEMBER_BY_ID = "api/committee_members/{id}";
        public const string ROUTE_URL_SAVE_GETCOMMITTEEMEMBER = "api/committee_members";
        public const string ROUTE_URL_UPDATE_GETCOMMITTEEMEMBER = "api/committee_members";
        public const string ROUTE_URL_DELETE_GETCOMMITTEEMEMBER = "api/committee_members/{id}";

        //Pre Approved Visitor
        public const string ROUTE_URL_GET_VISITORS = "api/PreApprovedVisitors";
        public const string ROUTE_URL_GETVISITORS_BY_ID = "api/PreApprovedVisitors/{id}";
        public const string ROUTE_URL_SAVE_VISITOR = "api/PreApprovedVisitors";
        public const string ROUTE_URL_UPDATE_VISITOR= "api/PreApprovedVisitors";
        public const string ROUTE_URL_DELETE_VISITOR = "api/PreApprovedVisitors/{id}";

        //Pets
        public const string ROUTE_URL_GET_PETS = "api/pets";
        public const string ROUTE_URL_GETPETS_BY_ID = "api/pets/{id}";
        public const string ROUTE_URL_SAVE_PETS = "api/pets";
        public const string ROUTE_URL_UPDATE_PETS = "api/pets";
        public const string ROUTE_URL_DELETE_PETS = "api/pets/{id}";

        //Country
        public const string ROUTE_URL_MASTER_COUNTRIES = "api/countries";
        public const string ROUTE_URL_MASTER_COUNTRY_BY_ID = "api/countries/{id}";
        public const string ROUTE_URL_MASTER_SAVE_COUNTRY = "api/country";
        public const string ROUTE_URL_MASTER_UPDATE_COUNTRY = "api/countries/{id}";
        public const string ROUTE_URL_MASTER_DELETE_COUNTRY = "api/countries/{id}";

        // City
        public const string ROUTE_URL_MASTER_CITIES = "api/cities";
        public const string ROUTE_URL_MASTER_CITY_BY_ID = "api/cities/{id}";
        public const string ROUTE_URL_MASTER_SAVE_CITY = "api/city";
        public const string ROUTE_URL_MASTER_UPDATE_CITY = "api/cities/{id}";
        public const string ROUTE_URL_MASTER_DELETE_CITY = "api/cities/{id}";

        // State
        public const string ROUTE_URL_MASTER_STATES = "api/states";
        public const string ROUTE_URL_MASTER_STATE_BY_ID = "api/states/{id}";
        public const string ROUTE_URL_MASTER_SAVE_STATE = "api/state";
        public const string ROUTE_URL_MASTER_UPDATE_STATE = "api/states/{id}";
        public const string ROUTE_URL_MASTER_DELETE_STATE = "api/states/{id}";

        // HelperRatingCategory
        public const string ROUTE_URL_MASTER_HELPER_RATING_CATEGORIES = "api/helperRatingCategories";
        public const string ROUTE_URL_MASTER_HELPER_RATING_CATEGORY_BY_ID = "api/helperRatingCategories/{id}";
        public const string ROUTE_URL_MASTER_SAVE_HELPER_RATING_CATEGORY = "api/helperRatingCategory";
        public const string ROUTE_URL_MASTER_UPDATE_HELPER_RATING_CATEGORY = "api/helperRatingCategories/{id}";
        public const string ROUTE_URL_MASTER_DELETE_HELPER_RATING_CATEGORY = "api/helperRatingCategories/{id}";

        // Lookup
        public const string ROUTE_URL_MASTER_LOOKUPS = "api/lookups";
        public const string ROUTE_URL_MASTER_LOOKUP_BY_ID = "api/lookups/{id}";
        public const string ROUTE_URL_MASTER_SAVE_LOOKUP = "api/lookup";
        public const string ROUTE_URL_MASTER_UPDATE_LOOKUP = "api/lookups/{id}";
        public const string ROUTE_URL_MASTER_DELETE_LOOKUP = "api/lookups/{id}";

        // DocumentTypes
        public const string ROUTE_URL_MASTER_DOCUMENT_TYPES = "api/documentTypes";
        public const string ROUTE_URL_MASTER_DOCUMENT_TYPE_BY_ID = "api/documentTypes/{id}";
        public const string ROUTE_URL_MASTER_SAVE_DOCUMENT_TYPE = "api/documentType";
        public const string ROUTE_URL_MASTER_UPDATE_DOCUMENT_TYPE = "api/documentTypes/{id}";
        public const string ROUTE_URL_MASTER_DELETE_DOCUMENT_TYPE = "api/documentTypes/{id}";

        // Amenity
        public const string ROUTE_URL_MASTER_AMENITIES = "api/amenities";
        public const string ROUTE_URL_MASTER_AMENITY_BY_ID = "api/amenities/{id}";
        public const string ROUTE_URL_MASTER_SAVE_AMENITY = "api/amenity";
        public const string ROUTE_URL_MASTER_UPDATE_AMENITY = "api/amenities/{id}";
        public const string ROUTE_URL_MASTER_DELETE_AMENITY = "api/amenities/{id}";

        // Policies
        public const string ROUTE_URL_MASTER_POLICIES = "api/policies";
        public const string ROUTE_URL_MASTER_POLICY_BY_ID = "api/policies/{id}";
        public const string ROUTE_URL_MASTER_SAVE_POLICY = "api/policy";
        public const string ROUTE_URL_MASTER_UPDATE_POLICY = "api/policies/{id}";
        public const string ROUTE_URL_MASTER_DELETE_POLICY = "api/policies/{id}";

        // PolicyDocuments
        public const string ROUTE_URL_MASTER_POLICY_DOCUMENTS = "api/policyDocuments";
        public const string ROUTE_URL_MASTER_POLICY_DOCUMENT_BY_ID = "api/policyDocuments/{id}";
        public const string ROUTE_URL_MASTER_SAVE_POLICY_DOCUMENT = "api/policyDocument";
        public const string ROUTE_URL_MASTER_UPDATE_POLICY_DOCUMENT = "api/policyDocuments/{id}";
        public const string ROUTE_URL_MASTER_DELETE_POLICY_DOCUMENT = "api/policyDocuments/{id}";

        // AmenityPolicy
        public const string ROUTE_URL_MASTER_AMENITY_POLICIES = "api/amenityPolicies";
        public const string ROUTE_URL_MASTER_AMENITY_POLICY_BY_ID = "api/amenityPolicies/{id}";
        public const string ROUTE_URL_MASTER_SAVE_AMENITY_POLICY = "api/amenityPolicy";
        public const string ROUTE_URL_MASTER_UPDATE_AMENITY_POLICY = "api/amenityPolicies/{id}";
        public const string ROUTE_URL_MASTER_DELETE_AMENITY_POLICY = "api/amenityPolicies/{id}";

        // AmenitySlot
        public const string ROUTE_URL_MASTER_AMENITY_SLOTS = "api/amenitySlots";
        public const string ROUTE_URL_MASTER_AMENITY_SLOT_BY_ID = "api/amenitySlots/{id}";
        public const string ROUTE_URL_MASTER_SAVE_AMENITY_SLOT = "api/amenitySlot";
        public const string ROUTE_URL_MASTER_UPDATE_AMENITY_SLOT = "api/amenitySlots/{id}";
        public const string ROUTE_URL_MASTER_DELETE_AMENITY_SLOT = "api/amenitySlots/{id}";

        // AmenitySpecialSchedules
        public const string ROUTE_URL_MASTER_AMENITY_SPECIAL_SCHEDULES = "api/amenitySpecialSchedules";
        public const string ROUTE_URL_MASTER_AMENITY_SPECIAL_SCHEDULE_BY_ID = "api/amenitySpecialSchedules/{id}";
        public const string ROUTE_URL_MASTER_SAVE_AMENITY_SPECIAL_SCHEDULE = "api/amenitySpecialSchedule";
        public const string ROUTE_URL_MASTER_UPDATE_AMENITY_SPECIAL_SCHEDULE = "api/amenitySpecialSchedules/{id}";
        public const string ROUTE_URL_MASTER_DELETE_AMENITY_SPECIAL_SCHEDULE = "api/amenitySpecialSchedules/{id}";

        // EmailTemplate
        public const string ROUTE_URL_MASTER_EMAIL_TEMPLATES = "api/emailTemplates";
        public const string ROUTE_URL_MASTER_EMAIL_TEMPLATE_ID = "api/emailTemplate/{id}";
        public const string ROUTE_URL_MASTER_SAVE_EMAIL_TEMPLATE = "api/emailTemplate";
        public const string ROUTE_URL_MASTER_UPDATE_EMAIL_TEMPLATE = "api/emailTemplate/{id}";
        public const string ROUTE_URL_MASTER_DELETE_EMAIL_TEMPLATE = "api/emailTemplate/{id}";

        // Language
        public const string ROUTE_URL_MASTER_LANGUAGES = "api/languages";
        public const string ROUTE_URL_MASTER_LANGUAGE_ID = "api/language/{id}";
        public const string ROUTE_URL_MASTER_SAVE_LANGUAGE = "api/language";
        public const string ROUTE_URL_MASTER_UPDATE_LANGUAGE = "api/language/{id}";
        public const string ROUTE_URL_MASTER_DELETE_LANGUAGE = "api/language/{id}";
        // TimeZone

        public const string ROUTE_URL_MASTER_TIME_ZONES = "api/timeZones";
        public const string ROUTE_URL_MASTER_TIME_ZONE_ID = "api/timeZone/{id}";
        public const string ROUTE_URL_MASTER_SAVE_TIME_ZONE = "api/timeZone";
        public const string ROUTE_URL_MASTER_UPDATE_TIME_ZONE = "api/timeZone/{id}";
        public const string ROUTE_URL_MASTER_DELETE_TIME_ZONE = "api/timeZone/{id}";

        // ParkingSlot
        public const string ROUTE_URL_MASTER_PARKING_SLOT = "api/parkingSlots";
        public const string ROUTE_URL_MASTER_PARKING_SLOT_ID = "api/parkingSlot/{id}";
        public const string ROUTE_URL_MASTER_SAVE_PARKING_SLOT = "api/parkingSlot";
        public const string ROUTE_URL_MASTER_UPDATE_PARKING_SLOT = "api/parkingSlot/{id}";
        public const string ROUTE_URL_MASTER_DELETE_PARKING_SLOT = "api/parkingSlot/{id}";

        #endregion

        #region Stored Procedure

        public static string SP_SQL_VALIDATE_USER = "exec [User].[ProcValidateUser] @UserName,@Password,@ReturnValue OUTPUT";

        //Article
        public static string SP_SQL_SAVE_ARTICLE = "exec [Education].[ProcSaveArticle] @JsonSaveArticle,@RecordType,@ReturnVal";
        public static string SP_SQL_DELETE_ARTICLE = "exec [Education].[ProcDeleteArticle] @JsonDeleteArticle,@ReturnVal";
        public static string SP_SQL_FETCH_ARTICLE = "exec [Education].[ProcFetchArticle] @ArticleID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";

        //Tenantuser
        public static string SP_SQL_SIGNUP_TENANTUSER = "exec [User].[ProcSaveAdminSignUp] @JsonSignUp,@RecordType,@ReturnVal OUTPUT";
        public static string SP_SQL_SENDOTP_TENANTUSER = "exec [User].[ProcGenerateOTP] @ReturnVal OUTPUT";
        public static string SP_SQL_VERIFYOTP_TENANTUSER = "exec [User].[ProcVerifyUserOTP] @UserEmail, @OTP, @ReturnValue OUTPUT";
        public static string SP_SQL_FORGOTPASSWORD_TENANTUSER = "exec [User].[ProcGenerateOTPforForgotPwd] @UserEmail, @ReturnVal OUTPUT";
        public static string SP_SQL_RESETPASSWORD_TENANTUSER = "exec [User].[ProcSaveResetPwd] @UserEmail, @CurrentPwd, @NewPwd, @ReturnMessage OUTPUT";
        public static string SP_SQL_APPROVEORREJECT_TENANTUSER = "exec [User].[ProcSaveAccountApproval] @JsonAccountApproval, @ReturnVal";
        public static string SP_SQL_LOGIN_TENANTUSER = "exec [User].[ProcUserLogin] @UserEmail, @UserPwd, @ReturnMessage OUTPUT";

        //Account
        public static string SP_SQL_SAVEACCOUNT_TENANTUSER = "exec [Tenant].[ProcSaveTenants] @JsonSaveTenants,@RecordType, @ReturnVal";
        public static string SP_SQL_FETCHACCOUNT_TENANT = "exec [Tenant].[ProcFetchTenants] @TenantID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";
        public static string SP_SQL_DELETE_ACCOUNT = "exec [Tenant].[ProcDeleteTenant] @JsonDeleteTenant,@ReturnVal OUTPUT";

        //Project
        public static string SP_SQL_SAVEPROJECT_TENANTUSER = "exec [Tenant].[ProcSaveProjects] @JsonSaveProjects,@RecordType, @ReturnVal";
        public static string SP_SQL_FETCHPROJECT_TENANT = "exec [Tenant].[ProcFetchProjects] @ProjectID,@TenantID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";
        public static string SP_SQL_DELETE_PROJECT = "exec [Tenant].[ProcDeleteProject] @JsonDeleteProject,@ReturnVal OUTPUT";

        //Tower
        public static string SP_SQL_SAVETOWER_TENANTUSER = "exec [Tenant].[ProcSaveTowers] @JsonSaveTowers,@RecordType, @ReturnVal";
        public static string SP_SQL_FETCHTOWER_TENANT = "exec [Tenant].[ProcFetchTowers] @TowerID,@ProjectID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";
        public static string SP_SQL_DELETE_TOWER = "exec [Tenant].[ProcDeleteTower] @JsonDeleteTower,@ReturnVal OUTPUT";

        //Floor
        public static string SP_SQL_SAVEFLOOR_TENANTUSER = "exec [Tenant].[ProcSaveFloors] @JsonSaveFloors,@RecordType, @ReturnVal";
        public static string SP_SQL_FETCHFLOOR_TENANT = "exec [Tenant].[ProcFetchFloors] @FloorID,@TowerID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";
        public static string SP_SQL_DELETE_FLOOR = "exec [Tenant].[ProcDeleteFloor] @JsonDeleteFloor,@ReturnVal OUTPUT";

        //Unit
        public static string SP_SQL_SAVEUNIT_TENANTUSER = "exec [Tenant].[ProcSaveUnits] @JsonSaveUnits,@RecordType, @ReturnVal";
        public static string SP_SQL_FETCHNUNIT_TENANT = "exec [Tenant].[ProcFetchUnit] @UnitID,@FloorID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";
        public static string SP_SQL_DELETE_UNIT = "exec [Tenant].[ProcDeleteUnit] @JsonDeleteUnit,@ReturnVal";

        //GreenInitiative
        public static string SP_SQL_SAVE_GREENINITIATIVE = "exec [Education].[ProcSaveGreenInitiative] @JsonSaveGreenInitiative,@RecordType, @ReturnVal";
        public static string SP_SQL_FETCH_GREENINITIATIVE = "exec [Education].[ProcFetchGreenInitiative] @InitiativeID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";
        public static string SP_SQL_DELETE_GREENINITIATIVE = "exec [Education].[ProcDeleteGreenInitiative] @JsonDeleteGreenInitiative,@ReturnVal";

        //EcoFriendlyTip
        public static string SP_SQL_SAVE_ECOFRIENDLYTIP = "exec [Education].[ProcSaveEcoFriendlyTip] @JsonSaveEcoFriendlyTip,@RecordType, @ReturnVal";
        public static string SP_SQL_FETCH_ECOFRIENDLYTIP = "exec [Education].[ProcFetchEcoFriendlyTip] @TipID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";
        public static string SP_SQL_DELETE_ECOFRIENDLYTIP = "exec [Education].[ProcDeleteEcoFriendlyTip] @JsonDeleteEcoFriendlyTip,@ReturnVal";

        //Question
        public static string SP_SQL_SAVE_QUESTION = "exec [Education].[ProcSaveQuestion] @JsonSaveQuestion,@RecordType, @ReturnVal";
        public static string SP_SQL_FETCH_QUESTION = "exec [Education].[ProcFetchQuestion] @QuestionID,@QuizID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";
        public static string SP_SQL_DELETE_QUESTION = "exec [Education].[ProcDeleteQuestion] @JsonDeleteQuestion,@ReturnVal";
        
        //UserQuizResult
        public static string SP_SQL_SAVE_USERQUIZRESULT = "exec [Education].[ProcSaveUserQuizResults] @JsonSaveUserQuizResult,@RecordType, @ReturnVal";
        public static string SP_SQL_FETCH_USERQUIZRESULT = "exec [Education].[ProcFetchUserQuizResults] @QuizID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";

        //User
        public static string SP_SQL_REGISTER_USER = "exec [User].[ProcSaveUserSignUp] @JsonSignUp,@RecordType, @ReturnVal OUTPUT";
        public static string SP_SQL_SAVE_USER = "exec [User].[ProcSaveUsers] @JsonSaveUsers,@RecordType, @ReturnVal OUTPUT";
        public static string SP_SQL_FETCH_USER = "exec [User].[ProcFetchUsers] @UserID,@UnitID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";
        public static string SP_SQL_DELETE_USER = "exec [User].[ProcDeleteUser] @JsonDeleteUser,@ReturnVal OUTPUT";

        public static string SP_SQL_FETCH_USERLOG = "exec [User].[ProcFetchUserAccessLog] @AccessLogID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";
        public static string SP_SQL_SAVE_USERLOG = "exec [User].[ProcSaveUserAccessLog] @JsonSaveAccessLog,@RecordType, @ReturnVal OUTPUT";

        public static string SP_SQL_SAVE_COMMITTEEMEMBER = "exec [User].[ProcSaveCommitteeMember] @JsonSaveCommitteeMember,@RecordType, @ReturnVal";
        public static string SP_SQL_FETCH_COMMITTEEMEMBER = "exec [User].[ProcFetchCommitteeMember] @CommitteeMemberID,@UserID,@CommitteeRoleID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";
        public static string SP_SQL_DELETE_COMMITTEEMEMBER = "exec [User].[ProcDeleteCommitteeMember] @JsonDeleteCommitteeMember,@ReturnVal OUTPUT";

        //Pre Approved Visitor
        public static string SP_SQL_SAVE_VISITOR = "exec [User].[ProcSavePreApprovedVisitor] @JsonSavePreApprovedVisitors,@RecordType, @ReturnVal";
        public static string SP_SQL_FETCH_VISITOR = "exec [User].[ProcFetchPreApprovedVisitors] @VisitorID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";
        public static string SP_SQL_DELETE_VISITOR = "exec [User].[ProcDeletePreApprovedVisitors] @JsonDeletePreApprovedVisitor,@ReturnVal OUTPUT";

        //Pets
        public static string SP_SQL_SAVE_PET = "exec [User].[ProcSaveUserPets] @JsonSavePets,@RecordType, @ReturnVal";
        public static string SP_SQL_FETCH_PET = "exec [User].[ProcFetchUserPets] @PetID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";
        public static string SP_SQL_DELETE_PET = "exec [User].[ProcDeleteUserPets] @JsonDeletePet,@ReturnVal OUTPUT";

        //Country
        public static string SP_SQL_SAVE_COUNTRY = "exec [Master].[ProcSaveCountry] @JsonSaveCountry,@RecordType,@ReturnVal";
        public static string SP_SQL_DELETE_COUNTRY = "exec [Master].[ProcDeleteCountry] @JsonDeleteCountry,@ReturnVal";
        public static string SP_SQL_FETCH_COUNTRIES = "exec [Master].[ProcFetchCountries] @CountryID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";

        // City
        public static string SP_SQL_SAVE_CITY = "exec [Master].[ProcSaveCity] @JsonSaveCity,@RecordType,@ReturnVal";
        public static string SP_SQL_DELETE_CITY = "exec [Master].[ProcDeleteCity] @JsonDeleteCity,@ReturnVal";
        public static string SP_SQL_FETCH_CITIES = "exec [Master].[ProcFetchCities] @CityID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";

        // State
        public static string SP_SQL_SAVE_STATE = "exec [Master].[ProcSaveState] @JsonSaveState,@RecordType,@ReturnVal";
        public static string SP_SQL_DELETE_STATE = "exec [Master].[ProcDeleteState] @JsonDeleteState,@ReturnVal";
        public static string SP_SQL_FETCH_STATES = "exec [Master].[ProcFetchStates] @StateID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";

        // HelperRatingCategory
        public static string SP_SQL_SAVE_HELPER_RATING_CATEGORY = "exec [Master].[ProcSaveRatingCategory] @JsonSaveRatingCategory,@RecordType,@ReturnVal";
        public static string SP_SQL_DELETE_HELPER_RATING_CATEGORY = "exec [Master].[ProcDeleteRatingCategory] @JsonDeleteRatingCategory,@ReturnVal";
        public static string SP_SQL_FETCH_HELPER_RATING_CATEGORIES = "exec [Master].[ProcFetchRatingCategories] @RatingCategoryID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";

        // Lookup
        public static string SP_SQL_SAVE_LOOKUP = "exec [Master].[ProcSaveLookup] @JsonSaveLookup,@RecordType,@ReturnVal";
        public static string SP_SQL_DELETE_LOOKUP = "exec [Master].[ProcDeleteLookup] @JsonDeleteLookup,@ReturnVal";
        public static string SP_SQL_FETCH_LOOKUPS = "exec [Master].[ProcFetchLookups] @LookupName,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";

        // DocumentTypes
        public static string SP_SQL_SAVE_DOCUMENT_TYPE = "exec [Master].[ProcSaveDocumentType] @JsonSaveDocumentType,@RecordType,@ReturnVal";
        public static string SP_SQL_DELETE_DOCUMENT_TYPE = "exec [Master].[ProcDeleteDocumentType] @JsonDeleteDocumentType,@ReturnVal";
        public static string SP_SQL_FETCH_DOCUMENT_TYPES = "exec [Master].[ProcFetchDocumentTypes] @DocumentTypeID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";

        // Amenity
        public static string SP_SQL_SAVE_AMENITY = "exec [Master].[ProcSaveAmenity] @JsonSaveAmenity,@RecordType,@ReturnVal";
        public static string SP_SQL_DELETE_AMENITY = "exec [Master].[ProcDeleteAmenity] @JsonDeleteAmenity,@ReturnVal";
        public static string SP_SQL_FETCH_AMENITIES = "exec [Master].[ProcFetchAmenity] @AmenityID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";

        // Policies
        public static string SP_SQL_SAVE_POLICY = "exec [Master].[ProcSavePolicies] @JsonSavePolicies,@RecordType,@ReturnVal";
        public static string SP_SQL_DELETE_POLICY = "exec [Master].[ProcDeletePolicies] @JsonDeletePolicies,@ReturnVal";
        public static string SP_SQL_FETCH_POLICIES = "exec [Master].[ProcFetchPolicies] @PolicyID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";

        //// PolicyDocuments
        //public static string SP_SQL_SAVE_POLICY_DOCUMENT = "exec [Master].[ProcSavePolicyDocument] @JsonSavePolicyDocument,@RecordType,@ReturnVal";
        //public static string SP_SQL_DELETE_POLICY_DOCUMENT = "exec [Master].[ProcDeletePolicyDocument] @JsonDeletePolicyDocument,@ReturnVal";
        //public static string SP_SQL_FETCH_POLICY_DOCUMENTS = "exec [Master].[ProcFetchPolicyDocuments] @PolicyDocumentID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";

        //// AmenityPolicy
        //public static string SP_SQL_SAVE_AMENITY_POLICY = "exec [Master].[ProcSaveAmenityPolicy] @JsonSaveAmenityPolicy,@RecordType,@ReturnVal";
        //public static string SP_SQL_DELETE_AMENITY_POLICY = "exec [Master].[ProcDeleteAmenityPolicy] @JsonDeleteAmenityPolicy,@ReturnVal";
        //public static string SP_SQL_FETCH_AMENITY_POLICIES = "exec [Master].[ProcFetchAmenityPolicies] @AmenityPolicyID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";

        // AmenitySlot
        public static string SP_SQL_SAVE_AMENITY_SLOT = "exec [Master].[ProcSaveAmenitySlot] @JsonSaveAmenitySlot,@RecordType,@ReturnVal";
        public static string SP_SQL_DELETE_AMENITY_SLOT = "exec [Master].[ProcDeleteAmenitySlot] @JsonDeleteAmenitySlot,@ReturnVal";
        public static string SP_SQL_FETCH_AMENITY_SLOTS = "exec [Master].[ProcFetchAmenitySlots] @AmenitySlotID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";

        // AmenitySpecialSchedules
        public static string SP_SQL_SAVE_AMENITY_SPECIAL_SCHEDULE = "exec [Master].[ProcSaveAmenitySpecialSchedule] @JsonSaveAmenitySpecialSchedule,@RecordType,@ReturnVal";
        public static string SP_SQL_DELETE_AMENITY_SPECIAL_SCHEDULE = "exec [Master].[ProcDeleteAmenitySpecialSchedule] @JsonDeleteAmenitySpecialSchedule,@ReturnVal";
        public static string SP_SQL_FETCH_AMENITY_SPECIAL_SCHEDULES = "exec [Master].[ProcFetchAmenitySpecialSchedules] @AmenitySpecialScheduleID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";

        // EmailTemplate
        public static string SP_SQL_SAVE_EMAIL_TEMPLATE = "exec [Master].[ProcSaveEmailTemplate] @JsonSaveEmailTemplate,@RecordType,@ReturnVal";
        public static string SP_SQL_DELETE_EMAIL_TEMPLATE = "exec [Master].[ProcDeleteEmailTemplate] @JsonDeleteEmailTemplate,@ReturnVal";
        public static string SP_SQL_FETCH_EMAIL_TEMPLATES = "exec [Master].[ProcFetchEmailTemplate] @EmailTemplateID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";

        // TimeZone
        public static string SP_SQL_SAVE_TIME_ZONE = "exec [Master].[ProcSaveTimeZone] @JsonSaveTimeZone,@RecordType,@ReturnVal";
        public static string SP_SQL_DELETE_TIME_ZONE = "exec [Master].[ProcDeleteTimeZone] @JsonDeleteTimeZone,@ReturnVal";
        public static string SP_SQL_FETCH_TIME_ZONES = "exec [Master].[ProcFetchTimeZone] @TimeZoneID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";

        // ParkingSlot
        public static string SP_SQL_SAVE_PARKING_SLOT = "exec [Master].[ProcSaveParkingSlots] @JsonSaveParkingSlot,@RecordType,@ReturnVal";
        public static string SP_SQL_DELETE_PARKING_SLOT = "exec [Master].[ProcDeleteParkingSlot] @JsonDeleteParkingSlot,@ReturnVal";
        public static string SP_SQL_FETCH_PARKING_SLOTS = "exec [Master].[ProcFetchParkingSlots] @ParkingSlotID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";

        // ParkingSlot
        public static string SP_SQL_SAVE_LANGUAGE = "exec [Master].[ProcSaveLanguages] @JsonSaveLanguage,@RecordType,@ReturnVal";
        public static string SP_SQL_DELETE_LANGUAGE = "exec [Master].[ProcDeleteLanguages] @JsonDeleteLanguage,@ReturnVal";
        public static string SP_SQL_FETCH_LANGUAGES = "exec [Master].[ProcFetchLanguages] @LanguageID,@SearchText,@pPageNo,@pRecordCount,@ReturnValue OUTPUT";
        #endregion

        #region SQL Parameters
        public static string SP_PARAM_SEARCH_TEXT = "@SearchText";
        public static string SP_PARAM_RETURN_VALUE = "@ReturnValue";
        public static string SP_PARAM_PAGE_NO = "@pPageNo";
        public static string SP_PARAM_RECORD_COUNT = "@pRecordCount";
        public static string SP_PARAM_RECORD_TYPE = "@RecordType";
        public static string JSON_RETURN_VAL = "@ReturnVal";
        public static string JSON_RETURN_MESSAGE = "@ReturnMessage";


        public static string SP_USERNAME = "@UserName";
        public static string SP_PASSWORD = "@Password";

        //Article
        public static string SP_PARAM_DELETE_ARTICLE = "@JsonDeleteArticle";
        public static string SP_PARAM_UPDATE_ARTICLE = "@JsonUpdateArticle";
        public static string SP_PARAM_SAVE_ARTICLE = "@JsonSaveArticle";
        public static string SP_PARAM_ARTICLE_ID = "@ArticleID";

        //TenantUser
        public static string SP_PARAM_SIGNUP_TENANTUSER = "@JsonSignUp";
        public static string SP_PARAM_APPROVALORREJECT_TENANTUSER = "@JsonAccountApproval";
        public static string SP_PARAM_REGISTRATION_TENANTUSER = "@JsonRegistration";
        public static string SP_PARAM_LOGIN_PASSWORD = "@UserPwd";
        public static string SP_PARAM_LOGIN_USEREMAIL = "@UserEmail";
        public static string SP_PARAM_LOGIN_OTP = "@OTP";

        //Account
        public static string SP_PARAM_SAVEACCOUNT = "@JsonSaveTenants";
        public static string SP_PARAM_TENANT_ID = "@TenantID";
        public static string SP_PARAM_DELETE_ACCOUNT = "@JsonDeleteTenant";

        //Project
        public static string SP_PARAM_SAVEPROJECT = "@JsonSaveProjects";
        public static string SP_PARAM_PROJECT_ID = "@ProjectID";
        public static string SP_PARAM_DELETE_PROJECT = "@JsonDeleteProject";

        //Tower
        public static string SP_PARAM_SAVETOWER = "@JsonSaveTowers";
        public static string SP_PARAM_TOWER_ID = "@TowerID";
        public static string SP_PARAM_DELETE_TOWER = "@JsonDeleteTower";

        //Floor
        public static string SP_PARAM_SAVEFLOOR = "@JsonSaveFloors";
        public static string SP_PARAM_FLOOR_ID = "@FloorID";
        public static string SP_PARAM_DELETE_FLOOR = "@JsonDeleteFloor";

        //Unit
        public static string SP_PARAM_SAVE_UNIT = "@JsonSaveUnits";
        public static string SP_PARAM_UNIT_ID = "@UnitID";
        public static string SP_PARAM_DELETE_UNIT = "@JsonDeleteUnit";

        //GreenInitiative
        public static string SP_PARAM_SAVE_GREENINITIATIVE = "@JsonSaveGreenInitiative";
        public static string SP_PARAM_GREENINITIATIVE_ID = "@InitiativeID";
        public static string SP_PARAM_DELETE_GREENINITIATIVE = "@JsonDeleteGreenInitiative";

        //EcoFriendlyTip
        public static string SP_PARAM_SAVE_ECOFRIENDLYTIP = "@JsonSaveEcoFriendlyTip";
        public static string SP_PARAM_ECOFRIENDLYTIP_ID = "@TipID";
        public static string SP_PARAM_DELETE_ECOFRIENDLYTIP = "@JsonDeleteEcoFriendlyTip";

        //Question
        public static string SP_PARAM_SAVE_QUESTION = "@JsonSaveQuestion";
        public static string SP_PARAM_QUESTION_ID = "@QuestionID";
        public static string SP_PARAM_QUIZ_ID = "@QuizID";
        public static string SP_PARAM_DELETE_QUESTION = "@JsonDeleteQuestion";

        //UserQuizResult
        public static string SP_PARAM_SAVE_USERQUIZRESULT = "@JsonSaveUserQuizResult";

        //User
        public static string SP_PARAM_SAVE_USER = "@JsonSaveUsers";
        public static string SP_PARAM_USER_ID = "@UserID";
        public static string SP_PARAM_DELETE_USER = "@JsonDeleteUser";

        public static string SP_PARAM_USERLOG_ID = "@AccessLogID";
        public static string SP_PARAM_SAVE_USERLOG = "@JsonSaveAccessLog";

        public static string SP_PARAM_SAVE_COMMITTEEMEMBER = "@JsonSaveCommitteeMember";
        public static string SP_PARAM_COMMITTEEMEMBER_ID = "@CommitteeMemberID";
        public static string SP_PARAM_COMMITTEEROLE_ID = "@CommitteeRoleID";
        public static string SP_PARAM_DELETE_COMMITTEEMEMBER = "@JsonDeleteCommitteeMember";

        //Pre Approved Visitor
        public static string SP_PARAM_SAVE_VISITOR = "@JsonSavePreApprovedVisitors";
        public static string SP_PARAM_VISITOR_ID = "@VisitorID";
        public static string SP_PARAM_DELETE_VISITOR = "@JsonDeletePreApprovedVisitor";

        //Pet
        public static string SP_PARAM_SAVE_PET = "@JsonSavePets";
        public static string SP_PARAM_PET_ID = "@PetID";
        public static string SP_PARAM_DELETE_PET = "@JsonDeletePet";

        //Country
        public static string SP_PARAM_COUNTRY_ID = "@CountryID";
        public static string SP_PARAM_SAVE_COUNTRY = "@JsonSaveCountry";
        public static string SP_PARAM_DELETE_COUNTRY = "@JsonDeleteCountry";

        // City
        public static string SP_PARAM_CITY_ID = "@CityID";
        public static string SP_PARAM_SAVE_CITY = "@JsonSaveCity";
        public static string SP_PARAM_DELETE_CITY = "@JsonDeleteCity";

        // State
        public static string SP_PARAM_STATE_ID = "@StateID";
        public static string SP_PARAM_SAVE_STATE = "@JsonSaveState";
        public static string SP_PARAM_DELETE_STATE = "@JsonDeleteState";

        // HelperRatingCategory
        public static string SP_PARAM_HELPER_RATING_CATEGORY_ID = "@RatingCategoryID";
        public static string SP_PARAM_SAVE_HELPER_RATING_CATEGORY = "@JsonSaveRatingCategory";
        public static string SP_PARAM_DELETE_HELPER_RATING_CATEGORY = "@JsonDeleteRatingCategory";

        // Lookup
        public static string SP_PARAM_LOOKUP_ID = "@LookupID";
        public static string SP_PARAM_SAVE_LOOKUP = "@JsonSaveLookup";
        public static string SP_PARAM_DELETE_LOOKUP = "@JsonDeleteLookup";
        public static string SP_PARAM_LOOKUP_NAME = "@LookupName";

        // DocumentTypes
        public static string SP_PARAM_DOCUMENT_TYPE_ID = "@DocumentTypeID";
        public static string SP_PARAM_SAVE_DOCUMENT_TYPE = "@JsonSaveDocumentType";
        public static string SP_PARAM_DELETE_DOCUMENT_TYPE = "@JsonDeleteDocumentType";

        // Amenity
        public static string SP_PARAM_AMENITY_ID = "@AmenityID";
        public static string SP_PARAM_SAVE_AMENITY = "@JsonSaveAmenity";
        public static string SP_PARAM_DELETE_AMENITY = "@JsonDeleteAmenity";

        // Policies
        public static string SP_PARAM_POLICY_ID = "@PolicyID";
        public static string SP_PARAM_SAVE_POLICY = "@JsonSavePolicies";
        public static string SP_PARAM_DELETE_POLICY = "@JsonDeletePolicies";

        // PolicyDocuments
        public static string SP_PARAM_POLICY_DOCUMENT_ID = "@PolicyDocumentID";
        public static string SP_PARAM_SAVE_POLICY_DOCUMENT = "@JsonSavePolicyDocument";
        public static string SP_PARAM_DELETE_POLICY_DOCUMENT = "@JsonDeletePolicyDocument";

        // AmenityPolicy
        public static string SP_PARAM_AMENITY_POLICY_ID = "@AmenityPolicyID";
        public static string SP_PARAM_SAVE_AMENITY_POLICY = "@JsonSaveAmenityPolicy";
        public static string SP_PARAM_DELETE_AMENITY_POLICY = "@JsonDeleteAmenityPolicy";

        // AmenitySlot
        public static string SP_PARAM_AMENITY_SLOT_ID = "@AmenitySlotID";
        public static string SP_PARAM_SAVE_AMENITY_SLOT = "@JsonSaveAmenitySlot";
        public static string SP_PARAM_DELETE_AMENITY_SLOT = "@JsonDeleteAmenitySlot";

        // AmenitySpecialSchedules
        public static string SP_PARAM_AMENITY_SPECIAL_SCHEDULE_ID = "@AmenitySpecialScheduleID";
        public static string SP_PARAM_SAVE_AMENITY_SPECIAL_SCHEDULE = "@JsonSaveAmenitySpecialSchedule";
        public static string SP_PARAM_DELETE_AMENITY_SPECIAL_SCHEDULE = "@JsonDeleteAmenitySpecialSchedule";

        //EmailTemplate
        public static string SP_PARAM_EMAIL_TEMPLATE_ID = "@EmailTemplateID";
        public static string SP_PARAM_SAVE_EMAIL_TEMPLATE = "@JsonSaveEmailTemplate";
        public static string SP_PARAM_DELETE_EMAIL_TEMPLATE = "@JsonDeleteEmailTemplate";

        //Language
        public static string SP_PARAM_LANGUAGE_ID = "@LanguageID";
        public static string SP_PARAM_SAVE_LANGUAGE = "@JsonSaveLanguage";
        public static string SP_PARAM_DELETE_LANGUAGE = "@JsonDeleteLanguage";

        //TimeZone
        public static string SP_PARAM_TIME_ZONE_ID = "@TimeZoneID";
        public static string SP_PARAM_SAVE_TIME_ZONE = "@JsonSaveTimeZone";
        public static string SP_PARAM_DELETE_TIME_ZONE = "@JsonDeleteTimeZone";

        //ParkingSlot
        public static string SP_PARAM_PARKING_SLOT_ID = "@ParkingSlotID";
        public static string SP_PARAM_SAVE_PARKING_SLOT = "@JsonSaveParkingSlot";
        public static string SP_PARAM_DELETE_PARKING_SLOT = "@JsonDeleteParkingSlot";

        #endregion

    }
}
