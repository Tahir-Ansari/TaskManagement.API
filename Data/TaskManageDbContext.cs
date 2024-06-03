using Microsoft.EntityFrameworkCore;

namespace TaskManagement.API;

public class TaskManageDbContext:DbContext
{
    public TaskManageDbContext(DbContextOptions<TaskManageDbContext> options):base(options)
    {
        
    }
    public DbSet<UserMaster> UserMasters { get; set; }
    public DbSet<TaskMaster> TaskMasters { get; set; }
    public DbSet<TaskStatus> TaskStatuses { get; set; }
    public DbSet<TaskPriority> TaskPriorities { get; set; }
    public DbSet<TaskCategory> TaskCategories { get; set; }
    public DbSet<TaskAssign> TaskAssigns { get; set; }
    public DbSet<TaskComment> TaskComments { get; set; }
    // public DbSet<TaskAttachment> TaskAttachments { get; set; }
    // public DbSet<Notification> Notifications { get; set; }
    // public DbSet<NotificationType> NotificationTypes { get; set; }
    // public DbSet<NotificationStatus> NotificationStatuses { get; set; }
    // public DbSet<NotificationUser> NotificationUsers { get; set; }
    // public DbSet<NotificationUserStatus> NotificationUserStatuses { get; set; }
    // public DbSet<NotificationUserType> NotificationUserTypes { get; set; }
    // public DbSet<NotificationUserMaster> NotificationUserMasters { get; set; }
    // public DbSet<NotificationUserDetail> NotificationUserDetails { get; set; }
    // public DbSet<NotificationUserDetailStatus> NotificationUserDetailStatuses { get; set; }
    // public DbSet<NotificationUserDetailType> NotificationUserDetailTypes { get; set; }
    // public DbSet<NotificationUserDetailMaster> NotificationUserDetailMasters { get; set; }
    // public DbSet<NotificationUserDetailUser> NotificationUserDetailUsers { get; set; }
    // public DbSet<NotificationUserDetailUserStatus> NotificationUserDetailUserStatuses { get; set; }
    // public DbSet<NotificationUserDetailUserType> NotificationUserDetailUserTypes { get; set; }
    // public DbSet<NotificationUserDetailUserMaster> NotificationUserDetailUserMasters { get; set; }
    // public DbSet<NotificationUserDetailUserDetail> NotificationUserDetailUserDetails { get; set; }
    // public DbSet<NotificationUserDetailUserDetailStatus> NotificationUserDetailUserDetailStatuses { get; set; }
    // public DbSet<NotificationUserDetailUserDetailType> NotificationUserDetailUserDetailTypes { get; set; }
    // public DbSet<NotificationUserDetailUserDetailMaster> NotificationUserDetailUserDetailMasters { get; set; }
}
