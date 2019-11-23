using Nsf.App.Utils;
using System;
using System.Data.Entity.Validation;
using System.Windows.Forms;


namespace Nsf.App
{
    public static class HandleExceptionExtension2
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void LogError(this Exception ex)
        {
            log.Error("NsfException", ex);
        }
    }
}

namespace Nsf.App.UI
{
	public static class HandleExceptionExtension
	{
		private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void TryCatch(this UserControl form, Action doit)
        {
            try
            {
                doit();
            }
            catch (NsfException ex)
            {
                log.Error("NsfException", ex);
                form.ShowNsfError(ex.Message);
            }
            catch (DbEntityValidationException ex)
            {
                try
                {
                    log.Error("DbEntityValidationException", ex);
                    foreach (DbEntityValidationResult item in ex.EntityValidationErrors)
                    {
                        foreach (var itemError in item.ValidationErrors)
                        {
                            log.Error(itemError.PropertyName + ":" + itemError.ErrorMessage);
                        }
                    }
                    form.ShowNsfError("Ocorreu um erro ao executar essa operação. Entre em contato com o administrador do sistema.");
                }
                catch
                {
                }
            }
            catch (Exception ex)
            {
                log.Error("Exception", ex);

#if DEBUG
                form.ShowNsfError("Ocorreu um erro ao executar essa operação. Entre em contato com o administrador do sistema.");
#else
					form.ShowNsfError("Ocorreu um erro ao executar essa operação. Entre em contato com o administrador do sistema.");
#endif
            }
        }


        


	}
}