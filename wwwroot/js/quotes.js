function randomQuotes()
{
    let quotesArray = [" “Reality doesn’t always give us the life that we desire, but we can always find what we desire between the pages of books.” ―Adelise M.Cullens", " “The more that you read, the more things you will know. The more that you learn, the more places you’ll go.”―Dr.Seuss, I Can Read With My Eyes Shut", "“I love the sound of the pages flicking against my fingers. Print against fingerprints. Books make people quiet, yet they are so loud.”―Nnedi Okorafor", "“Reading is an active, imaginative act; it takes work.”―Khaled Hosseini", "“In the end, we’ll all become stories.”―Margaret Atwood, Moral Disorder and Other Stories"];
    //quotes taken from:https://bookriot.com/book-lover-quotes/
    let randomQuoteSelctor = Math.floor(Math.random() * quotesArray.length);
    let whereQuoteWillBePlaced = document.querySelector(".dailyQuotes");
    whereQuoteWillBePlaced.textContent = quotesArray[randomQuoteSelctor];
}
randomQuotes();