
using Exceptions;
using Exceptions.Helpers.Exceptions;
using System.ComponentModel.DataAnnotations;
using System.Data;

////void Calculate()
////{
////    bool isCorrectCalculate = true;

////    try
////    {

////        int[] arr = { 1, 2, 3 };

////        arr[5] = 100;

////        int a = 5;
////        int b = 0;
////        var result = a / b;

////        Console.WriteLine(result);

////    }
////    catch (DivideByZeroException ex)
////    {
////        Console.WriteLine(ex.Message);
////    }
////    catch (IndexOutOfRangeException ex)
////    {
////        Console.WriteLine(ex.Message);
////    }

////    catch (Exception ex)
////    {
////        isCorrectCalculate = false;
////        //    int a = 5;
////        //    bool b = true;

////        Console.WriteLine(ex.Message);
////    }
////    finally
////    {
////        SendMessage(isCorrectCalculate);

////        Console.WriteLine("Finally");

////    }

////}

////Calculate();

////void SendMessage(bool isCorrectCalculate)
////{
////    if (isCorrectCalculate)
////    {
////        Console.WriteLine("Your message sent successfully ");
////    }
////    else
////    {
////        Console.WriteLine("Your message failed");
////    }
////}


////string GetById(int? id)
////{

////    try
////    {

////        if (id == null)
////        {
////            throw new ArgumentNullException(nameof(id), "Salam , menem Exception");

////            throw new CustomArgumentNullException("Argument can't be null");
////        }


////        ArgumentNullException.ThrowIfNull(id);

////        return "Kamran bey";
////    }
////    catch (Exception ex)
////    {
////        return ex.Message;
////        return "Argument null";
////    }


////}

////var result = GetById(null);

////Console.WriteLine(result);



