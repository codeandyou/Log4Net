# Log4Net
Step 1 - Add log4net library into your project. "log4net.dll"

Step 2 - Add Log4net setting in web.config

<!-- Log4net section -->
      <section name="log4net" type="log4net.Config.Log4NetConfigurationSectionHandler, log4net" />

          <log4net debug="true">
              <appender name="RollingLogFileAppender" type="log4net.Appender.RollingFileAppender">
                <file value="C:\\log.txt" />
                <appendToFile value="true" />
                <rollingStyle value="Size" />
                <maxSizeRollBackups value="10" />
                <maximumFileSize value="10MB" />
                <staticLogFileName value="true" />
                <layout type="log4net.Layout.PatternLayout">
                  <conversionPattern value="%-5p %d %5rms %-22.22c{1} %-18.18M - %m%n" />
                </layout>
              </appender>
              <root>
                <level value="DEBUG" />
                <appender-ref ref="RollingLogFileAppender" />
              </root>
            </log4net>


Step 3 -  Add Log4net settings in Global.asax

          log4net.Config.XmlConfigurator.Configure();


Step 4 - Log4net settings

          private static log4net.ILog Log { get; set; }

ILog log = log4net.LogManager.GetLogger(typeof(classtype));      //type of class

            log.Debug("Debug message");
            log.Warn("Warn message");
            log.Error("Error message");
            log.Fatal("Fatal message");


Note: After done every step if you not able to see any log in c: drive. That means your application don't have administrator permission.

You can see such type of message - "ErrorCode: GenericFailure. Unable to acquire lock on file C:\log.txt. Access to the path 'C:\log.txt' is denied."

Now start your visual studio as administrator or create log.txt file into c: drive and give him administrator persmission.


